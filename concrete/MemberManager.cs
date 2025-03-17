using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class MemberManager: IMemberService
    {
        IMemberDal _memberDal;

        public MemberManager(IMemberDal memberDal)
        {
            _memberDal = memberDal;
        }

        public void TDelete(Member t)
        {
            throw new NotImplementedException();
        }

        public Member TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Member> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TInsert(Member t)
        {
            if(t.MemberName.Length>=5 && t.MemberName.Length<=20 &&
                t.MemberSurname.Length<=30 && t.MemberSurname.StartsWith("a") && 
                t.MemberID >= 8)
            {
                _memberDal.Insert(t);
            }
            else
            {
                //hata mesajları
            }
        }

        public void TUpdate(Member t)
        {
            throw new NotImplementedException();
        }
    }
}
