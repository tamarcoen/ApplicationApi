using DataEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuisnessLayer.Interface
{
    public interface IApplicationBO
    {
        List<Application> GetApplications();
        List<Card> GetCards(string appId);
        List<Trans> GetTrans(string appId);
    }
}
