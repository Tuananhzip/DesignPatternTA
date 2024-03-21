using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTH8.Observer
{
    internal class CompanySubject : ISubjectCompany
    {
        List<IObserverCompany> companies = new List<IObserverCompany>();
        private User user;
        public CompanySubject(User user)
        {
            this.user = user;
        }
        public void Notify(string message)
        {
            foreach(IObserverCompany company in companies)
            {
                company.Update(message);
            }
        }

        public void Post(string content)
        {
            string message = $"{user.GetUsername()} is posting a new topic with content: {content}";
            Notify(message);
        }

        public void Subscribe(IObserverCompany company)
        {
            companies.Add(company);
        }

        public void Unsubscribe(IObserverCompany company)
        {
            companies.Remove(company);
        }
    }
}
