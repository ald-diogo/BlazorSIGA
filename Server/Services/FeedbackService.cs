using BlazorSIGA.Pages;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorSIGA.Server.Services
{
    public class FeedbackService
    {
        private List<Feedback> feedbacks = new List<Feedback>();

        public List<Feedback> GetFeedbacks() => feedbacks;

        public void AddFeedback(Feedback feedback)
        {
            feedback.Id = feedbacks.Count > 0 ? feedbacks.Max(static f => f.Id) + 1 : 1;
            feedbacks.Add(feedback);
        }
    }
}

