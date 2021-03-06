﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Senparc.Weixin.QY.Helpers
{
    public static class MsgTypeHelper
    {
        #region RequestMsgType
        /// <summary>
        /// 根据xml信息，返回RequestMsgType
        /// </summary>
        /// <returns></returns>
        public static RequestMsgType GetRequestMsgType(XDocument doc)
        {
            return GetRequestMsgType(doc.Root.Element("MsgType").Value);
        }
        /// <summary>
        /// 根据xml信息，返回RequestMsgType
        /// </summary>
        /// <returns></returns>
        public static RequestMsgType GetRequestMsgType(string str)
        {
            return (RequestMsgType)Enum.Parse(typeof(RequestMsgType), str, true);
        }

        #endregion

        #region ThirdPartyInfo
        /// <summary>
        /// 根据xml信息，返回ThirdPartyInfo
        /// </summary>
        /// <returns></returns>
        public static ThirdPartyInfo GetThirdPartyInfo(XDocument doc)
        {
            return GetThirdPartyInfo(doc.Root.Element("InfoType").Value);
        }
        /// <summary>
        /// 根据xml信息，返回RequestInfoType
        /// </summary>
        /// <returns></returns>
        public static ThirdPartyInfo GetThirdPartyInfo(string str)
        {
            return (ThirdPartyInfo)Enum.Parse(typeof(ThirdPartyInfo), str, true);
        }

        #endregion

        #region ResponseMsgType
        /// <summary>
        /// 根据xml信息，返回ResponseMsgType
        /// </summary>
        /// <returns></returns>
        public static ResponseMsgType GetResponseMsgType(XDocument doc)
        {
            return GetResponseMsgType(doc.Root.Element("MsgType").Value);
        }
        /// <summary>
        /// 根据xml信息，返回ResponseMsgType
        /// </summary>
        /// <returns></returns>
        public static ResponseMsgType GetResponseMsgType(string str)
        {
            return (ResponseMsgType)Enum.Parse(typeof(ResponseMsgType), str, true);
        }

        #endregion
    }
}
