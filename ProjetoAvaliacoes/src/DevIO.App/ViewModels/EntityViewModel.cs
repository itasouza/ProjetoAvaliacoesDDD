using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.App.ViewModels
{
    public class EntityViewModel
    {
        [Key]
        public int Id { get; set; }
    }
}
