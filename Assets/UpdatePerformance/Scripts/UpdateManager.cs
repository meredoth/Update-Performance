using System.Collections.Generic;
using UnityEngine;

namespace UpdatePerformance
{
public interface IMyUpdate
{
   void MyUpdate();
}

public class UpdateManager : MonoBehaviour
{
   private readonly HashSet<IMyUpdate> _myUpdates = new();

   public void AddUpdatable(IMyUpdate myUpdate) => _myUpdates.Add(myUpdate);
   public void RemoveUpdatable(IMyUpdate myUpdate) => _myUpdates.Remove(myUpdate);

   private void RunUpdates()
   {
      using var e = _myUpdates.GetEnumerator();
      while (e.MoveNext())
      {
         e.Current?.MyUpdate();
      }
   }

   private void Update() => RunUpdates();
}
}