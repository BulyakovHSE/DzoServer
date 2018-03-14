using System;
using System.Runtime.Serialization;

namespace ActsModel.Model
{
    /// <summary>
    /// ПЛАН ПРОВЕРКИ ГРАЖДАН
    /// </summary>
    [DataContract]
    public class CitizensCheckPlan : ActIndividual
    {
        /// <summary>
        /// (наименование органа муниципального земельного контроля)
        /// </summary>
        public string TerritorialBodyName;

        /// <summary>
        /// Утвержден
        /// (Ф.И.О. и подпись руководителя органа муниципального земельного контроля)
        /// </summary>
        public string ApprovedByInfo;

        /// <summary>
        /// От 
        /// _______________ 20___ г.
        /// </summary>
        public DateTime? ApprovedTime;

        /// <summary>
        /// План проведения плановых проверок граждан на 
        /// 20___ год
        /// </summary>
        public string ScheduledInspectionYear;

        /// <summary>
        /// Объект земельных отношений, подлежащий проверке
        /// кадастровый номер земельного участка, его площадь, категория, 
        /// вид разрешенного использования и местоположение
        /// </summary>
        public string EarthObject;

        /// <summary>
        /// Фамилия, имя, отчество (последнее при наличии) гражданина
        /// </summary>
        public string CitizenName;

        /// <summary>
        /// Цель проведения проверки
        /// </summary>
        public string CheckAim;

        /// <summary>
        /// Основание проведения проверки
        /// </summary>
        public string CheckBase;

        /// <summary>
        /// Дата начала проведения проверки (Указывается календарный месяц начала проведения проверки.)
        /// </summary>
        public string CheckStartDate;

        /// <summary>
        /// Срок проведения плановой проверки 
        // (рабочих дней)
        /// </summary>
        public string CheckDurationInDays;

        /// <summary>
        ///  Наименование федерального органа государственного земельного надзора, 
        // с которым проверка проводится совместно
        /// </summary>
        public string FederalBodyName;
    }
}
