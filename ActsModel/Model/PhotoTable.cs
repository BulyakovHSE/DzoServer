using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ActsModel.Model
{
    /// <summary>
    /// ФОТОТАБЛИЦА
    /// </summary>
    [DataContract]
    public class PhotoTable : ActCommon
    {
        /// <summary>
        /// наименование органа муниципального земельного контроля
        /// </summary>
        [DataMember]
        public string MunitipalControlName { get; set; }

        /// <summary>
        /// приложение к акту проверки от ... 
        /// "___" ________ 20__ г. 
        /// </summary>
        [DataMember]
        public DateTime? AdditionToActDate { get; set; }

        /// <summary>
        /// Номер акта проверки
        /// </summary>
        [DataMember]
        public string ActNum { get; set; }

        /// <summary>
        /// наименование юридического лица, Ф.И.О. должностного лица, индивидуального предпринимателя, Ф.И.О.гражданина
        /// </summary>
        [DataMember]
        public string PersonsInfo { get; set; }

        /// <summary>
        /// кадастровый номер земельного участка, его площадь, вид разрешенног использования, местоположение земельного участка
        /// </summary>
        [DataMember]
        public string AreaInfo { get; set; }

        /// <summary>
        /// Фотографирование производилось: указывается марка, идентификационны параметры фотоаппарата
        /// </summary>
        [DataMember]
        public string DeviceInfo { get; set; }

        /// <summary>
        /// (Ф.И.О. должностного лица, составившего фототаблицу)
        /// </summary>
        [DataMember]
        public string PhototableCreator { get; set; }

        /// <summary>
        /// Снимки
        /// (Номер снимка - Краткое описание (адрес, по которому проводилось фотографирование)
        /// </summary>
        [DataMember]
        public List<Photo> Photos { get; set; }
    }
}
