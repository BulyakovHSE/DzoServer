using System;
using System.Runtime.Serialization;

namespace DlrModel.Model
{
    /// <summary>
    /// ОБМЕР ПЛОЩАДИ ЗЕМЕЛЬНОГО УЧАСТКА
    /// </summary>
    [DataContract]
    public class AreaMeasurement : ActCommon
    {
        public AreaMeasurement():base(ActType.ОбмерПлощадиЗу){}

        /// <summary>
        /// (наименование органа муниципального земельного контроля)
        /// </summary>
        [DataMember]
        public string TerritorialBodyName { get; set; }

        /// <summary>
        /// приложение к акту проверки от 
        /// "__" _________ 20__ г. 
        /// </summary>
        [DataMember]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Номер акта
        /// </summary>
        [DataMember]
        public string ActNum { get; set; }

        /// <summary>
        /// Обмер земельного участка произвели:
        /// (должность, Ф.И.О. должностного лица,производившего обмер земельного участка)
        /// </summary>
        [DataMember]
        public string MeasureAuthorInfo { get; set; }

        /// <summary>
        /// в присутствии
        /// (должность, наименование юридического лица, Ф.И.О. законного
        /// представителя юридического лица, Ф.И.О. физического лица)
        /// </summary>
        [DataMember]
        public string RepresentativePersonInfo { get; set; }

        /// <summary>
        /// по адресу: 
        /// (кадастровый номер земельного участка, его площадь, вид разрешенного использования,
        /// местоположение земельного участка)
        /// </summary>
        [DataMember]
        public string AreaAddress { get; set; }

        /// <summary>
        /// Обмер площади производился: 
        /// (указывается марка, идентификационные параметры измерительного инструмента)
        /// </summary>
        [DataMember]
        public string DeviceInfo { get; set; }

        /// <summary>
        /// Согласно обмеру площадь земельного участка составляет
        /// (площадь земельного участка прописью БЕЗ кв.м)
        /// </summary>
        [DataMember]
        public string AreaSquare { get; set; }

        /// <summary>
        /// Расчет площади:
        /// </summary>
        [DataMember]
        public string AreaCalculation { get; set; }

        /// <summary>
        /// Особые отметки: 
        /// </summary>
        [DataMember]
        public string SpecialMarks { get; set; }
    }
}
