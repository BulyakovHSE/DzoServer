using System;
using System.Collections.Generic;

namespace ActsModel.Model
{
    /// <summary>
    /// ФОТОТАБЛИЦА
    /// </summary>
    public class PhotoTable : ActCommon
    {
        /// <summary>
        /// наименование органа муниципального земельного контроля
        /// </summary>
        public string MunitipalControlName;

        /// <summary>
        /// приложение к акту проверки от ... 
        /// "___" ________ 20__ г. 
        /// </summary>
        public DateTime AdditionToActDate;

        /// <summary>
        /// Номер акта проверки
        /// </summary>
        public string ActNum;

        /// <summary>
        /// наименование юридического лица, Ф.И.О. должностного лица, индивидуального предпринимателя, Ф.И.О.гражданина
        /// </summary>
        public string PersonsInfo;

        /// <summary>
        /// кадастровый номер земельного участка, его площадь, вид разрешенног использования, местоположение земельного участка
        /// </summary>
        public string AreaInfo;

        /// <summary>
        /// Фотографирование производилось: указывается марка, идентификационны параметры фотоаппарата
        /// </summary>
        public string DeviceInfo;

        /// <summary>
        /// (Ф.И.О. должностного лица, составившего фототаблицу)
        /// </summary>
        public string PhototableCreator;

        /// <summary>
        /// Снимки
        /// (Номер снимка - Краткое описание (адрес, по которому проводилось фотографирование)
        /// </summary>
        public List<Photo> Photos;
    }
}
