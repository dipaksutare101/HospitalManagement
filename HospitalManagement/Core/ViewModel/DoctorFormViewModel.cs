using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using HospitalManagement.Core.Models;

namespace HospitalManagement.Core.ViewModel
{
    public class DoctorFormViewModel
    {

        // why Created  ViewModel for Doctor?
        //-> i want to save data in two table AspnetUser and Doctor 
        //-> display Form in data of Register Form and Doctor in single Form

        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [Required]
        public string Phone { get; set; }

        public bool isAvailable { get; set; }

        public string Address { get; set; }
        [Required]
        public int Specialization { get; set; }

        public IEnumerable<Specialization> Specializations { get; set; }

        public IEnumerable<Doctor> Doctors { get; set; }

        public RegisterViewModel RegisterViewModel { get; set; }

    }
}