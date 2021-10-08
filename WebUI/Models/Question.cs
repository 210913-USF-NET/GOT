using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
	public class Question
	{
		[Required]
		[Range(1,5, ErrorMessage = "Invalid input")]
		public int Question1 { get; set; }

		[Required]
		[Range(1, 5, ErrorMessage = "Invalid input")]
		public int Question2 { get; set; }

		[Required]
		[Range(1, 5, ErrorMessage = "Invalid input")]
		public int Question3 { get; set; }

		[Required]
		[Range(1, 5, ErrorMessage = "Invalid input")]
		public int Question4 { get; set; }

		[Required]
		[Range(1, 5, ErrorMessage = "Invalid input")]
		public int Question5 { get; set; }

		[Required]
		[Range(1, 5, ErrorMessage = "Invalid input")]
		public int Question6 { get; set; }

		[Required]
		[Range(1, 5, ErrorMessage = "Invalid input")]
		public int Question7 { get; set; }

		[Required]
		[Range(1, 5, ErrorMessage = "Invalid input")]
		public int Question8 { get; set; }

		[Required]
		[Range(1, 5, ErrorMessage = "Invalid input")]
		public int Question9 { get; set; }

		[Required]
		[Range(1, 5, ErrorMessage = "Invalid input")]
		public int Question10 { get; set; }
	}
}
