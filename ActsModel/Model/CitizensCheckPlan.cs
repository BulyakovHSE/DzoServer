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
        [DataMember]
        public string TerritorialBodyName { get; set; }

        /// <summary>
        /// Утвержден
        /// (Ф.И.О. и подпись руководителя органа муниципального земельного контроля)
        /// </summary>
        [DataMember]
        public string ApprovedByInfo { get; set; }

        /// <summary>
        /// От 
        /// _______________ 20___ г.
        /// </summary>
        [DataMember]
        public DateTime? ApprovedTime { get; set; }

        /// <summary>
        /// План проведения плановых проверок граждан на 
        /// 20___ год
        /// </summary>
        [DataMember]
        public string ScheduledInspectionYear { get; set; }

        /// <summary>
        /// Объект земельных отношений, подлежащий проверке
        /// кадастровый номер земельного участка, его площадь, категория, 
        /// вид разрешенного использования и местоположение
        /// </summary>
        [DataMember]
        public string EarthObject { get; set; }

        /// <summary>
        /// Фамилия, имя, отчество (последнее при наличии) гражданина
        /// </summary>
        [DataMember]
        public string CitizenName { get; set; }

        /// <summary>
        /// Цель проведения проверки
        /// </summary>
        [DataMember]
        public string CheckAim { get; set; }

        /// <summary>
        /// Основание проведения проверки
        /// </summary>
        [DataMember]
        public string CheckBase { get; set; }

        /// <summary>
        /// Дата начала проведения проверки (Указывается календарный месяц начала проведения проверки.)
        /// </summary>
        [DataMember]
        public string CheckStartDate { get; set; }

        /// <summary>
        /// Срок проведения плановой проверки 
        /// (рабочих дней)
        /// </summary>
        [DataMember]
        public string CheckDurationInDays { get; set; }

        /// <summary>
        ///  Наименование федерального органа государственного земельного надзора, 
        /// с которым проверка проводится совместно
        /// </summary>
        [DataMember]
        public string FederalBodyName { get; set; }
    }
}
