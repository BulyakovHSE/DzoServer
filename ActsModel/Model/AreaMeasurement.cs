using System;

namespace ActsModel.Model
{
    /// <summary>
    /// ОБМЕР ПЛОЩАДИ ЗЕМЕЛЬНОГО УЧАСТКА
    /// </summary>
    public class AreaMeasurement : ActCommon
    {
        /// <summary>
        /// (наименование органа муниципального земельного контроля)
        /// </summary>
        public string TerritorialBodyName;

        /// <summary>
        /// приложение к акту проверки от 
        /// "__" _________ 20__ г. 
        /// </summary>
        public DateTime Date;

        /// <summary>
        /// Номер акта
        /// </summary>
        public string ActNum;

        /// <summary>
        /// Обмер земельного участка произвели:
        /// (должность, Ф.И.О. должностного лица,производившего обмер земельного участка)
        /// </summary>
        public string MeasureAuthorInfo;

        /// <summary>
        /// в присутствии
        /// (должность, наименование юридического лица, Ф.И.О. законного
        /// представителя юридического лица, Ф.И.О. физического лица)
        /// </summary>
        public string RepresentativePersonInfo;

        /// <summary>
        /// по адресу: 
        /// (кадастровый номер земельного участка, его площадь, вид разрешенного использования,
        /// местоположение земельного участка)
        /// </summary>
        public string AreaAddress;

        /// <summary>
        /// Обмер площади производился: 
        /// (указывается марка, идентификационные параметры измерительного инструмента)
        /// </summary>
        public string DeviceInfo;

        /// <summary>
        /// Согласно обмеру площадь земельного участка составляет
        /// (площадь земельного участка прописью БЕЗ кв.м)
        /// </summary>
        public string AreaSquare;

        /// <summary>
        /// Расчет площади:
        /// </summary>
        public string AreaCalculation;

        /// <summary>
        /// Особые отметки: 
        /// </summary>
        public string SpecialMarks;
    }
}
