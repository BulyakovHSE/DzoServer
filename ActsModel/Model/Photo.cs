namespace ActsModel.Model
{
    /// <summary>
    /// ФОТО
    /// </summary>
    public class Photo
    {
        /// <summary>
        /// Номер снимка
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Краткое описание снимка (адрес, по которому проводилось фотографирование)
        /// </summary>
        public string Description { get; set; }
    }
}
