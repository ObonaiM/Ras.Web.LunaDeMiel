using Ras.Web.LuneDeMiel.ViewModels.Gift;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ras.Web.LuneDeMiel.Logics
{
    public class GiftLogic
    {
        public IList<GiftViewModel> SelectGift()
        {
            var result = new List<GiftViewModel>();

            for (var i = 0; i < 1000; i++)
            {
                result.Add(new GiftViewModel
                {
                    Name = string.Format("オレンジとベリーの宝石箱{0}", i),
                    Price = 1836,
                    Items = new List<GiftItemViewModel>
                    {
                        new GiftItemViewModel
                        {
                            Name = "スペイン　オレンジ"
                        },
                        new GiftItemViewModel
                        {
                            Name = "はちみつコンフィチュール　3種のベリー"
                        }
                    }
                });
            }

            return result;
        }
    }
}