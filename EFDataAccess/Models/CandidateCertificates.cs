﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFDataAccess.Models
{
    public class CandidateCertificates 
    {
        public int CandidateCertificatesId { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ExaminationDate { get; set; }

        // Connections to other entities
        public virtual Certificate Certificate { get; set; }
        public virtual CertificateAssessment CertificateAssessment { get; set; } 
        public ICollection<TopicAssesment> TopicAssesments { get; set; }
    }
}
