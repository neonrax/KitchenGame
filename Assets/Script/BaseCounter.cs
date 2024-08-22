using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCounter : MonoBehaviour,IKitchenObjectParent
{
   public static event EventHandler OnAnyObjectPlacedHere;

   public static void ResetStaticData()
   {
      OnAnyObjectPlacedHere = null;
   }

   [SerializeField] private Transform counterTopPoint;

   private KitchenObject kitchenObject;

   public virtual void Interact(Player player)
   {
      Debug.LogError("BaseCounter");
   }

   public Transform GetKitchenObjectNextTransform()
   {
      return counterTopPoint;
   }

   public void SetKitchenObject(KitchenObject kitchenObject)
   {
      this.kitchenObject = kitchenObject; 
   }

   public KitchenObject GetKitchenObject()
   {
      return kitchenObject;
   }

   public void ClearKitchenObject()
   {
      kitchenObject = null;
   }

   public bool HasKitchenObject()
   {
      return kitchenObject != null;
   }
}