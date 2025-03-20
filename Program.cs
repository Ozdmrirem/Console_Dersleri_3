using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;

namespace Console_Dersleri_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lokasyon Listeleme
            //LocationManager locationManager= new LocationManager (new EfLocationDal());
            //var values = locationManager.TGetList();

            //void listele()
            //{
            //    foreach (var value in values)
            //    {
            //        Console.WriteLine(value.LocationName);
            //        Console.WriteLine("-------------------");
            //    }
            //}

            //Location location = new Location();
            //location.LocationName = "Rotterdam";
            //locationManager.TInsert(location);
            //listele();

            //var locationValue = locationManager.TGetById(4);
            //locationManager.TDelete(locationValue);

            //var locationValue = locationManager.TGetById(2);
            //locationValue.LocationName = "Çanakkale";
            //locationManager.TUpdate(locationValue);
            //Console.Write("Güncellendi");

            //MemberManager memberManager = new MemberManager(new EfMemberDal());
            //var values = memberManager.TGetList();
            //foreach (var value in values) 
            //    {
            //        Console.WriteLine(value.MemberName + " " + value.MemberSurname);
            //        Console.WriteLine("--------------------------");
            //    }
            //Member member=new Member();
            //member.MemberName = "a";
            //member.MemberSurname = "b";
            //memberManager.TInsert(member);
            //Console.WriteLine("Ekleme yapıldı");
            //var valueMember = memberManager.TGetById(8);
            //memberManager.TDelete(valueMember);
            //foreach (var item in valueMember)
            //{
            //    Console.WriteLine(item.);
            //}
            //Console.WriteLine("işlem yapıldı");

            //valueMember.MemberName = "Aslı";
            //valueMember.MemberSurname = "Meşe";
            //memberManager.TUpdate(valueMember);
            //Console.WriteLine("İşlem yapıldı");

            CommentManager commentManager = new CommentManager(new EfCommentDal());
            var values = commentManager.TGetList();
            foreach (var value in values)
            {

            }

            Console.ReadLine();
        }
    }
}
