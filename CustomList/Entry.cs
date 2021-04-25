using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.IO.Compression;

namespace CustomList
{
    // the actual class holding the data on entries
    public class Entry
    {
        public string name { get; private set; } // name of the entry (e.g. "The mummy 1999")
        // placeholder for image
        public int score { get; private set; } // score for entry (e.g. 2, would be 2/10)
        public string description { get; private set; } // description of the entry
        public byte[] image { get; private set; }
        public string date { get; private set; }
        // later on the user will be able to add aditional columns as he desires
        // (e.g. progress, location, ect...)
        private string[] additionalColumns;

        public Entry(string Name, string Image, int Score, string Description, string Date)
        {
            this.name = Name;
            this.score = Score;
            this.description = Description;
            this.date = Date;
            if (Image != "openFileDialog1" && Image.Length != 0)//this is the default path if nothing has been selected
            {
                ConvertPathToBytes(Image);
            }
        }

        public Entry(string Name, byte[] Image, int Score, string Description, string Date)
        {
            this.name = Name;
            this.score = Score;
            this.description = Description;
            this.date = Date;
            this.image = Image;
        }
        public Entry(string Name)
        {
            this.name = Name;
        }
        public string SelectedColumn(int index)
        {
            return this.additionalColumns[index];
        }

        private void ConvertPathToBytes(string path)
        {
            Image img = Image.FromFile(path);
            ImageConverter _imageConverter = new ImageConverter();
            image = (byte[])_imageConverter.ConvertTo(img, typeof(byte[]));
            var compressed = CompressBuffer(image);
        }

        private static byte[] CompressBuffer(byte[] byteArray)
        {
            MemoryStream strm = new MemoryStream();
            GZipStream GZipStrem = new GZipStream(strm, CompressionMode.Compress, true);
            GZipStrem.Write(byteArray, 0, byteArray.Length);
            GZipStrem.Flush();
            strm.Flush();
            byte[] ByteArrayToreturn = strm.GetBuffer();
            GZipStrem.Close();
            strm.Close();
            return ByteArrayToreturn;
        }
        private static byte[] DeCompressBuffer(byte[] byteArray)
        {
            MemoryStream strm = new MemoryStream(byteArray);
            GZipStream GZipStrem = new GZipStream(strm, CompressionMode.Decompress, true);
            List<byte> ByteListUncompressedData = new List<byte>();

            int bytesRead = GZipStrem.ReadByte();
            while (bytesRead != -1)
            {
                ByteListUncompressedData.Add((byte)bytesRead);
                bytesRead = GZipStrem.ReadByte();
            }
            GZipStrem.Flush();
            strm.Flush();
            GZipStrem.Close();
            strm.Close();
            return ByteListUncompressedData.ToArray();
        }
        public Image GetImage()
        {
            using (var ms = new MemoryStream(image))
            {
                return Image.FromStream(ms);
            }
        }
    }
}
