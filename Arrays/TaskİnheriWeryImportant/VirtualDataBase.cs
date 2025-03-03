using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskİnheriWeryImportant
{
    public static class VirtualDataBase
    {
        private static ArrayList _db = new ArrayList();

        public static bool IsbarcodeDublicate(string barcode, int? exeptId=null)
        {
            if (_db!=null && _db.Count>0)
            {
                for (int i = 0; i < _db.Count; i++)
                {
                    Item item = (Item)_db[i];
                    if (item.Barcode==barcode && !item.isDeleted && item.Id!=exeptId)
                    {
                        return true;
                    }      
                }
               
            }
            return false;
        }

        public static void NewItem(Item newItem)
        {
            if (newItem!=null && !string.IsNullOrEmpty(newItem.Barcode))
            {
                newItem.CreatedDate = DateTime.Now;
                newItem.CreateUser = 100;
                _db.Add(newItem);
            }
        }

        public static void NewItems(params Item[] newItems)
        {
            if (newItems != null)
            {
                foreach (var item in newItems)
                {
                    if (!string.IsNullOrEmpty(item.Barcode))
                    {
                        if (IsbarcodeDublicate(item.Barcode))
                        {
                            Console.WriteLine("Bu barcode daha once basqa mehsul ucun elave edilib");    
                        }
                        else
                        {
                            item.CreatedDate = DateTime.Now;
                            item.CreateUser = 100;
                            _db.Add(item);
                        }
                    }
                }
               
            }
        }

        public static void UpdateItem(Item updateItem)
        {
            if (updateItem!=null && !string.IsNullOrEmpty(updateItem.Barcode))
            {
                if (_db!=null &&_db.Count>0)
                {
                    for (int i = 0; i < _db.Count; i++)
                    {
                        Base item=(Base)_db[i];
                        if (item.Id==updateItem.Id)
                        {
                            if (!IsbarcodeDublicate(updateItem.Barcode, item.Id))
                            {
                                updateItem.EditDate = DateTime.Now;
                                updateItem.EditUser = 101;
                                break;
                            }
                        }
                    }
                }
            }
        }


        public static void Delete(Item deleteItem)
        {
            if (deleteItem != null)
            {
                if (_db != null && _db.Count > 0)
                {
                    for (int i = 0; i < _db.Count; i++)
                    {
                        Base item = (Base)_db[i];
                        if (item.Id == deleteItem.Id)
                        {
                            deleteItem.DeletedDate = DateTime.Now;
                            deleteItem.DeleteUser = 100;
                            deleteItem.isDeleted = true;
                            break;
                        }
                    }
                }
            }
        }
    }
}
