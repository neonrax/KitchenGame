using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class ClearCounter : BaseCounter
{
   [SerializeField] private KitchenObjectSO kitchenObjectSO;

   public override void Interact(Player player)
   {
      if(!HasKitchenObject())
      {
         if(player.HasKitchenObject())
         {
            player.GetKitchenObject().SetKitchenObjectParent(this);
         }
         else
         {
            return;
         }
      }


      else
      {
         if(player.HasKitchenObject())
         {
            return;
         }
         
         
         else
         {
            GetKitchenObject().SetKitchenObjectParent(player);
         }
      
      }   
   }
}