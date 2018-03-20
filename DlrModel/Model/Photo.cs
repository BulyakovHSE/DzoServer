using System.Runtime.Serialization;

namespace DlrModel.Model
{
    /// <summary>
    /// ФОТО
    /// </summary>
    [DataContract]
    public class Photo
    {
        /// <summary>
        /// Номер снимка
        /// </summary>
        [DataMember]
        public string Id { get; set; }

        /// <summary>
        /// Краткое описание снимка (адрес, по которому проводилось фотографирование)
        /// </summary>
        [DataMember]
        public string Description { get; set; }
    }
}
