﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portal.CMS.Entities.Entities.Authentication
{
    public class UserToken
    {
        [Key]
        public int UserTokenId { get; set; }

        [Required]
        public UserTokenType UserTokenType { get; set; }

        [Required]
        public string Token { get; set; }

        [ForeignKey(nameof(User))]
        public int UserId { get; set; }

        public virtual User User { get; set; }

        [Required]
        public DateTime DateAdded { get; set; }

        public DateTime? DateRedeemed { get; set; }
    }
}