﻿using System;

namespace ActsModel.Model
{
    // ОБМЕР ПЛОЩАДИ ЗЕМЕЛЬНОГО УЧАСТКА
    public class AreaMeasurement
    {
        // (наименование органа муниципального земельного контроля)
        public string TerritorialBodyName;

        // приложение к акту проверки от 
        // "__" _________ 20__ г. 
        public DateTime Date;

        // Номер акта
        public string ActNum;

        // Обмер земельного участка произвели:
        // (должность, Ф.И.О. должностного лица,производившего обмер земельного участка)
        public string MeasureAuthorInfo;

        // в присутствии
        // (должность, наименование юридического лица, Ф.И.О. законного
        // представителя юридического лица, Ф.И.О. физического лица)
        public string RepresentativePersonInfo;

        // по адресу: 
        // (кадастровый номер земельного участка, его площадь, вид разрешенного использования,
        // местоположение земельного участка)
        public string AreaAddress;

        //Обмер площади производился: 
        // (указывается марка, идентификационные параметры измерительного инструмента)
        public string DeviceInfo;

        // Согласно обмеру площадь земельного участка составляет
        // (площадь земельного участка прописью БЕЗ кв.м)
        public string AreaSquare;

        // Расчет площади:
        public string AreaCalculation;

        // Особые отметки: 
        public string SpecialMarks;
    }
}