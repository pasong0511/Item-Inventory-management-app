using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ECount.SDK
{
    //--이벤트 추가--
    public delegate void OnChangeServerStatus(string status);
    public delegate void EventHandler(string name, object payload);

    public class EventSDK
    {
        //이벤트 핸들러 구분 키와 이벤트 함수 저장할 딕셔너리 생성
        static Dictionary<string, EventHandler> handlerDic = new Dictionary<string, EventHandler>();

        //이벤트 핸들러 등록
        static public void RegisterEventHandler(string eventName, EventHandler handler)    //onClick이랑 콜백
        {
            // 있으면 모아주기
            if (handlerDic.ContainsKey(eventName))
            {
                handlerDic[eventName] += handler;
            }
            else
            { // 없으면 새로 등록
                handlerDic.Add(eventName, handler);
            }
        }

        //등록된 함수 실행
        static public void EventEmit(string eventName, object payload = null)
        {
            var handler = handlerDic[eventName];
            if (handler == null)
            {
                return;
            }

            handler(eventName, payload);
        }
    }    
}
