﻿using CSharpEgitimKampi301.DataAccessLayer.Abstract;
using CSharpEgitimKampi301.DataAccessLayer.Repositories;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLayer.EntityFramework
{
    public class EfAdminDal:GenericRepository<Admin>, IAdminDal
    {
    }
}
/*
 Ekle, Sil, Güncelle, Listele ve Id'ye Göre Getir -> bütün entity'ler için metotlar
 İçinde a harfi geçmeyen kullanıcıları listele -> entity'e özgü metot
 
 */