﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Policy;
using System.Web;

namespace ExamWebApplication2.Models
{
	[Table("UserInfo")]
	public class UserInfo
	{
		//[Key]
		//public Guid UserId { get; set; } = Guid.NewGuid();
		[Key]
		[Required]
		[StringLength(50, MinimumLength = 4)]
		public string UserName { get; set; }
		[Required]
		[StringLength(50, MinimumLength = 6)]
		[DataType(DataType.Password)]
		public string Password { get; set; }

		//[EnumDataType(typeof(UserRole))]
		public string Role { get; set; }

	}

	//public enum UserRole
	//{
	//    Admin, User, Student, Teacher
	//}
}