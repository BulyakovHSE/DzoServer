﻿using System;

namespace ActsModel.Model
{
    // Распоряжение о проверке ЮЛ, ИП
    public class OrderInspectionUlIp
    {
        // Наименование территориального органа администрации Перми, уполномоченного 
        // на осуществеление муницип. зем. ко
        public string TerritorialBodyName;

        // о проведении .. проверки
        // (плановой/внеплановой, документарной/выездной)
        public string CheckType;

        // от 
        // от “___” _____  _____ г.

        // Номер приказа
        public string OrderNum;

        // Провести проверку в отношении: 
        // (наименование юридического лица, фамилия, имя, отчество (последнее – при наличии) индивидуального предпринимателя)
        public string InspectionTarget;

        // Место нахождения: 
        // (юридического лица (филиалов, представительств, обособленных структурных подразделений), места фактического осуществления деятельности индивидуальным предпринимателем и (или) используемых ими производственных объектов)
        public string TargetPlace;

        // Назначить лицом(ами), уполномоченным(и) на проведение проверки: 
        // (фамилия, имя, отчество (последнее – при наличии), должность должностного лица (должностных лиц), уполномоченного(ых) на проведение проверки)
        public string CheckerInfo;

        // Привлечь к проведению проверки в качестве экспертов, представителей экспертных организаций следующих лиц: 
        // (фамилия, имя, отчество (последнее – при наличии), должности привлекаемых к проведению проверки
        // экспертов и(или) наименование экспертной организации с указанием реквизитов свидетельства
        // об аккредитации и наименования органа по аккредитации, выдавшего свидетельство об аккредитации)
        public string ExpertsInfo;

        // Настоящая проверка проводится в рамках: 
        // (наименование вида (видов) государственного контроля (надзора), муниципального контроля, реестровый(ые) номер(а) функции(й) в федеральной государственной информационной системе “Федеральный реестр государственных и муниципальных услуг (функций)”
        public string CheckingScopes;

        // Установить, что: настоящая проверка проводится с целью:  
        public string CheckingAim;

        // задачами настоящей проверки являются:
        public string CheckingTasks;

        // Срок проведения проверки:  
        public string CheckingDuration;

        // К проведению проверки приступить с “__” ______ 20__ года.
        public DateTime CheckingTimeStart;

        //Проверку окончить не позднее “__” ______ 20__ года.
        public DateTime CheckingTimeFinish;

        // Правовые основания проведения проверки: ссылка на положения нормативного правового акта, в соответствии с которым осуществляется проверка
        public string RightCheckingBases;

        // Обязательные требования и (или) требования, установленные муниципальными правовыми актами, подлежащие проверке
        public string MandatoryRequirements;

        // В процессе проверки провести следующие мероприятия по контролю, 
        // необходимые для достижения целей и задач проведения проверки 
        // (с указанием наименования мероприятия по контролю и сроков его проведения):
        // 3 строки под номерами
        public string CheckingEvents;

        // Перечень положений об осуществлении государственного контроля (надзора) и муниципального контроля, 
        // административных регламентов по осуществлению государственного контроля (надзора), осуществлению муниципального контроля (при их наличии):
        // (с указанием наименований, номеров и дат их принятия)
        public string ProvisionsListOfStateControl;

        // Перечень документов, представление которых юридическим лицом, индивидуальным предпринимателем необходимо для достижения целей и задач проведения проверки:
        // (должность, фамилия, инициалы руководителя, заместителя руководителя органа государственного контроля (надзора), органа муниципального контроля, издавшего распоряжение или приказ о проведении проверки)
        public string DocumentsForSuccess;

        // фамилия, имя, отчество (последнее – при наличии) и должность должностного лица, непосредственно подготовившего проект распоряжения (приказа), контактный телефон, электронный адрес (при наличии)
        public string OrderCreatorInfo;
    }
}