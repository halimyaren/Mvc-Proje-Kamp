using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T> //Artık buraya herhangi bir tablo gelebilir(T)
    {                               //Her tablo için tek tek interface tanımlamaya gerek yok. Tanımlanmamalı!
        //CRUD işlemlerini birer metot olarak tanımlayacağız.
        //Type Name();
        List<T> List();  //Tipi List adı da List olan bir metot tanımladık.
        void Insert(T p); //Kategori sınıfından gelen bir p paremetresine göre ekleme yapar.
        void Update(T p);//Kategori sınıfından gelen bir p paremetresine göre güncelleme yapar.
        void Delete(T p);  //Kategori sınıfından gelen bir p paremetresine göre silme yapar.

        List<T> List(Expression<Func<T, bool>> filter); //Bir başka List adında metot. Bu metot ise şartlı(parametreli)
                                                        //listeleme işlemi yapar
    }
}
