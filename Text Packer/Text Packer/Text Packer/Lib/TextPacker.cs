using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lib
{
    /// <summary>
    /// Provides an extract/insert tool.
    /// </summary>
    public static class TextPacker
    {
        /// <summary>
        /// Extracts text from a data buffer.
        /// </summary>
        /// <param name="bits">The bits of header (16 or 32).</param>
        /// <param name="buffer">The buffer data.</param>
        /// <returns>A string array.</returns>
        public static string[] Extract(byte bits, byte[] buffer)
        {
            List<string> collection = new List<string>();

            BinaryReader Reader;

            byte[] b;
            byte c;

            string text;
            int count, offset;
            long pos;

            Reader = new BinaryReader(new MemoryStream(buffer));

            using (Reader)
            {
                // Get the count of texts
                b = Reader.ReadBytes(bits / 8);
                if (BitConverter.IsLittleEndian)
                    Array.Reverse(b);

                count = BitConverter.ToUInt16(b, 0) / (bits / 8);

                Reader.BaseStream.Position = 0;

                // Get the texts
                for (int i = 0; i < count; i++)
                {
                    b = Reader.ReadBytes(bits / 8);
                    if (BitConverter.IsLittleEndian)
                        Array.Reverse(b);

                    offset = BitConverter.ToUInt16(b, 0);

                    pos = Reader.BaseStream.Position;

                    // Get the string
                    text = string.Empty;

                    Reader.BaseStream.Position = offset;

                    do
                    {
                        c = Reader.ReadByte();

                        if (c != 0x00)
                        {
                            if (c == 0x0a)
                                text += "\\r";
                            else
                                text += (char)c;
                        }
                    } while (c != 0x00);

                    collection.Add(text);

                    Reader.BaseStream.Position = pos;
                }
            }
            Reader.Close();
            Reader.Dispose();

            return collection.ToArray();
        }
        /// <summary>
        /// Inserts text into a data buffer.
        /// </summary>
        /// <param name="bits">The bits of header (16 or 32).</param>
        /// <param name="collection">The text collection.</param>
        /// <returns>A byte array.</returns>
        public static byte[] Insert(byte bits, string[] collection)
        {
            List<byte> buffer = new List<byte>();

            int offset;
            int firstOffset;

            byte[] b;

            // Replace /r by newline
            for (int i = 0; i < collection.Length; i++)
                collection[i] = collection[i].Replace("\\r", "\r");

            // Sets the offsets
            firstOffset = (collection.Length) * (bits / 8);
            offset = firstOffset;

            for (int i = 0; i < collection.Length; i++)
            {
                if (bits == 16)
                    b = BitConverter.GetBytes((ushort)offset);
                else
                    b = BitConverter.GetBytes(offset);

                if (BitConverter.IsLittleEndian)
                    Array.Reverse(b);

                buffer.AddRange(b);

                offset += collection[i].Length + 1;
            }

            // Sets the text
            for (int i = 0; i < collection.Length; i++)
                buffer.AddRange(Encoding.GetEncoding(437).GetBytes(collection[i] + (char)0x00));

            return buffer.ToArray();
        }
    }
}
