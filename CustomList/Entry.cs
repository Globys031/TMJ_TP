using System;
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
        public int watchCount { get; set; }
        // later on the user will be able to add aditional columns as he desires
        // (e.g. progress, location, ect...)
        private string[] additionalColumns;

        public Entry(string Name, string Image, int Score, string Description, string Date, int WatchCount)
        {
            this.name = Name;
            this.score = Score;
            this.description = Description;
            this.date = Date;
            this.watchCount = WatchCount;
            if (Image != "openFileDialog1" && Image.Length != 0)//this is the default path if nothing has been selected
            {
                ConvertPathToBytes(Image);
            }
        }

        public Entry(string Name, byte[] Image, int Score, string Description, string Date, int WatchCount)
        {
            this.name = Name;
            this.score = Score;
            this.description = Description;
            this.date = Date;
            this.image = Image;
            this.watchCount = WatchCount;
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
            var tmp = (byte[])_imageConverter.ConvertTo(img, typeof(byte[]));
            image = Compress(tmp);
        }

        private static byte[] Compress(byte[] inputData)
        {
            if (inputData == null)
                throw new ArgumentNullException("inputData must be non-null");

            using (var compressIntoMs = new MemoryStream())
            {
                using (var gzs = new BufferedStream(new GZipStream(compressIntoMs,
                 CompressionMode.Compress), inputData.Length))
                {
                    gzs.Write(inputData, 0, inputData.Length);
                }
                return compressIntoMs.ToArray();
            }
        }

        private static byte[] Decompress(byte[] inputData)
        {
            if (inputData == null)
                throw new ArgumentNullException("inputData must be non-null");

            using (var compressedMs = new MemoryStream(inputData))
            {
                using (var decompressedMs = new MemoryStream())
                {
                    using (var gzs = new BufferedStream(new GZipStream(compressedMs,
                     CompressionMode.Decompress), inputData.Length))
                    {
                        gzs.CopyTo(decompressedMs);
                    }
                    return decompressedMs.ToArray();
                }
            }
        }
        public Image GetImage()
        {
            using (var ms = new MemoryStream(Decompress(image)))
            {
                return Image.FromStream(ms);
            }
        }
    }
}
