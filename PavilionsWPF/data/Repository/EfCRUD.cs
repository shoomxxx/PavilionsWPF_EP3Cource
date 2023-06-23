﻿using PavilionsWPF.data.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PavilionsWPF.data.Repository
{
    public class EfCRUD
    {
        public class CRUD<TEntity, TCode> where TEntity : class
        {
            /// <summary>
            /// Удаление объекта из базы данных Pavilions
            /// </summary>
            /// <param name="model">Модель которая должна быть удалена</param>
            /// <returns>Возвращает переданную модель если она удалена, null - была ошибка</returns>
            public virtual TEntity Delete(TEntity model)
            {
                try
                {
                    if (model == null) return null;
                    using (db_PavilionsEntities db = new db_PavilionsEntities())
                    {
                        db.Set<TEntity>().Remove(model);
                        db.SaveChanges();
                        return model;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.InnerException.Message);
                    return null;
                }

            }

            /// <summary>
            /// Достать список объектов из базы данных Pavilions
            /// </summary>
            /// <returns>Возвращает список</returns>
            public virtual IEnumerable<TEntity> GetMany()
            {
                try
                {
                    using (db_PavilionsEntities db = new db_PavilionsEntities())
                    {
                        return db.Set<TEntity>().ToList();
                    }
                }
                catch
                {
                    return Enumerable.Empty<TEntity>();
                }
            }

            /// <summary>
            /// Достает 1 элемент из базы данных Pavilions
            /// </summary>
            /// <param name="item">Свойство модели по которому будет происходить поиск</param>
            /// <returns>Возвращает объект если все успешно, null - была ошибка</returns>
            public virtual TEntity GetOne(TCode item)
            {
                try
                {
                    if (item == null) return null;
                    using (db_PavilionsEntities db = new db_PavilionsEntities())
                    {
                        return db.Set<TEntity>().Find(item);
                    }
                }
                catch
                {
                    return null;
                }
            }

            /// <summary>
            /// Вставка в базу данных Pavilions
            /// </summary>
            /// <param name="model">Объект для вставки</param>
            /// <returns>Возвращает null, если объект успешно вставлен, иначе ошибка</returns>
            public virtual string Insert(TEntity model)
            {
                try
                {
                    if (model == null) return null;
                    using (db_PavilionsEntities db = new db_PavilionsEntities())
                    {
                        db.Set<TEntity>().Add(model);
                        db.SaveChanges();
                        return null;
                    }

                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }

            /// <summary>
            /// Обновление объекта базы данных Pavilions
            /// </summary>
            /// <param name="model">Объект который будет обновлен</param>
            /// <returns>Возвращает null, если объект успешно вставлен, иначе ошибка</returns>
            /*public virtual string Update(TEntity model)
            {
                try
                {
                    if (model == null) return null;
                    using (CinemaEntities db = new CinemaEntities())
                    {
                        db.Set<TEntity>().Add(model);
                        db.SaveChanges();
                        return null;
                    }

                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }*/
        }
    }
}
