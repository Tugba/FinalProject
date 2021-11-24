using Core.Entities; 
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //generic constraint
    //class: referans tip 
    //IEntity: IEntity olabilir veya IEntity implemente eden bir nesne olabilir.
    //new(): newlenebilir olmalı
  public  interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null); //idye göre vs filtreler yazıp listelememizi sağlıyor
        T Get(Expression<Func<T, bool>> filter); //T döndüren get operasyonu //detaya gitmek için
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

        

    }
}
