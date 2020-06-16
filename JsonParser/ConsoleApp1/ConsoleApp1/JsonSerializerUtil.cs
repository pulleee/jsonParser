using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace ConsoleApp1
{
    public static class JsonSerializerUtil
    {
        /// <summary>
        /// Deserialisiert ein Objekt im Json-Format aus einer Datei.
        /// </summary>
        /// <typeparam name="TSerializable">Daten-Klasse (POCO)</typeparam>
        /// <param name="file">Dateifpad</param>
        /// <returns>Deserialisiertes Objekt</returns>
        public static TSerializable JsonDeSerialize<TSerializable>(string file)
            where TSerializable : class
        {
            using (var fileStream = File.Open(file, FileMode.Open))
            using (var buffer = new BufferedStream(fileStream, 65536))
            {
                return JsonDeSerialize<TSerializable>(buffer);
            }
        }

        /// <summary>
        /// Deserialisiert ein Objekt im Json-Format aus einem Stream.
        /// </summary>
        /// <typeparam name="TSerializable">Daten-Klasse (POCO)</typeparam>
        /// <param name="stream">Lesbarer Stream</param>
        /// <returns>Deserialisiertes Objekt</returns>
        public static TSerializable JsonDeSerialize<TSerializable>(Stream stream)
            where TSerializable : class
        {
            var serializer = new DataContractJsonSerializer(typeof(TSerializable));
            return (TSerializable)serializer.ReadObject(stream);
        }
    }
}
