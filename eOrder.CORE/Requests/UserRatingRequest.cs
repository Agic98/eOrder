using System;
using System.ComponentModel.DataAnnotations;

namespace eOrder.CORE.Requests
{
    public class UserRatingRequest
    {
        public int? UserFromId { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = nameof(Resources.ReqField))]
        public int UserToId { get; set; }
        [Range(1, 5, ErrorMessage = nameof(Resources.RatingBetween1And5))]
        public int Rating { get; set; }
        public string Description { get; set; }
    }
}
