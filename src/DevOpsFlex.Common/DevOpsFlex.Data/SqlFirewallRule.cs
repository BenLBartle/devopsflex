﻿namespace DevOpsFlex.Data
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class SqlFirewallRule
    {
        [Key]
        public int Id { get; set; }

        [Required, ForeignKey("System")]
        public int SystemId { get; set; }
        public virtual DevOpsSystem System { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [Required, MinLength(7), MaxLength(15)]
        public string StartIp { get; set; }

        [Required, MinLength(7), MaxLength(15)]
        public string EndIp { get; set; }
    }
}
