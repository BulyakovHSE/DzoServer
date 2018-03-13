using System;
using System.Collections.Generic;

namespace ActsModel.Model
{
    // ФОТОТАБЛИЦА
    public class PhotoTable
    {
        // наименование органа муниципального земельного контроля
        public string MunitipalControlName;

        // приложение к акту проверки от ... 
        // "___" ________ 20__ г. 
        public DateTime AdditionToActDate;

        // Номер акта проверки
        public string ActNum;

        // наименование юридического лица, Ф.И.О. должностного лица, индивидуального предпринимателя, Ф.И.О.гражданина
        public string PersonsInfo;

        // кадастровый номер земельного участка, его площадь, вид разрешенног использования, местоположение земельного участка
        public string AreaInfo;

        // Фотографирование производилось: указывается марка, идентификационны параметры фотоаппарата
        public string DeviceInfo;

        // (Ф.И.О. должностного лица, составившего фототаблицу)
        public string PhototableCreator;

        // Снимки
        // (Номер снимка - Краткое описание (адрес, по которому проводилось фотографирование)
        public List<Photo> Photos;
    }
}
