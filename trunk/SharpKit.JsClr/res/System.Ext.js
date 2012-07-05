/*Generated by SharpKit 5 v4.28.3000*/
if (typeof($CreateException)=='undefined') 
{
    function $CreateException(ex, error) 
    {
        if(error==null)
            error = new Error();
        if(ex==null)
            ex = new System.Exception.ctor();       
        for (var p in ex)
           error[p] = ex[p];
        return error;
    }
}
if(typeof(JsTypes) == "undefined")
    var JsTypes=[];
var System$Runtime$Serialization$IExtensibleDataObject={fullname:"System.Runtime.Serialization.IExtensibleDataObject",baseTypeName:"System.Object",assemblyName:"SharpKit.JsClr",Kind:"Interface"};
JsTypes.push(System$Runtime$Serialization$IExtensibleDataObject);
var SharpKit$PropertyInfoExtensions=
{
    fullname:"SharpKit.PropertyInfoExtensions",
    baseTypeName:"System.Object",
    staticDefinition:
    {
        IsStatic:function(pi)
        {
            return pi._IsStatic;
        },
        IsPublic:function(pi)
        {
            throw new Error('Not Implemented');
        }
    },
    assemblyName:"SharpKit.JsClr",
    Kind:"Class",
    definition:
    {
        ctor:function()
        {
            System.Object.ctor.call(this);
        }
    }
};
JsTypes.push(SharpKit$PropertyInfoExtensions);
var SharpKit$Extensions2=
{
    fullname:"SharpKit.Extensions2",
    baseTypeName:"System.Object",
    staticDefinition:
    {
        GetValueOrDefaultIfNullOrEmpty:function(s,defaultValue)
        {
            if(s==null || s.length==0) return defaultValue; return s;
        },
        IsNullOrEmpty$$String:function(s)
        {
            return s == null || s.length == 0;
        },
        IsNotNullOrEmpty$$String:function(s)
        {
            return s != null && s.length > 0;
        },
        HtmlEscape:function(s)
        {
            return s.Replace$$String$$String("&","&amp;").Replace$$String$$String("<","&lt;").Replace$$String$$String(">","&gt;").Replace$$String$$String("\n","<br/>");
        },
        ReplaceFirst$$String$$String$$String:function(s,search,replace)
        {
            return s.ReplaceFirst(search, replace);
        },
        ReplaceFirst$$String$$String$$String$$StringComparison:function(s,search,replace,comparisonType)
        {
            var index=s.indexOf(search,comparisonType);
            if(index != -1)
            {
                var finalStr=System.String.Concat$$String$$String$$String(s.substr(0,index),replace,s.substr(search.length + index));
                return finalStr;
            }
            return s;
        },
        FixCamelCasing:function(s)
        {
            var sb=new System.Text.StringBuilder.ctor();
            var first=true;
            var $it14=s.GetEnumerator();
            while($it14.MoveNext())
            {
                var c=$it14.get_Current();
                if(System.Char.IsUpper$$Char(c) && !first)
                {
                    sb.Append$$Char(" ");
                }
                sb.Append$$Char(c);
                first = false;
            }
            return sb.toString();
        },
        RemoveLast:function(s,count)
        {
            return s.substr(s, s.length-count);
        },
        TrimEnd:function(s,trimText)
        {
            if(s.EndsWith$$String(trimText))
                return SharpKit.Extensions2.RemoveLast(s,trimText.length);
            return s;
        },
        EqualsIgnoreCase:function(s1,s2)
        {
            return System.String.Compare$$String$$String$$Boolean(s1,s2,true) == 0;
        }
    },
    assemblyName:"SharpKit.JsClr",
    Kind:"Class",
    definition:
    {
        ctor:function()
        {
            System.Object.ctor.call(this);
        }
    }
};
JsTypes.push(SharpKit$Extensions2);
var SharpKit$JavaScript$Utils$Js=
{
    fullname:"SharpKit.JavaScript.Utils.Js",
    baseTypeName:"System.Object",
    staticDefinition:
    {
        cctor:function()
        {
            SharpKit.JavaScript.Utils.Js.undefined = null;
        },
        escape:function(s)
        {
            return escape(s);
        },
        ToJsFunction:function(del)
        {
            return del._ToJsFunction();
        },
        JsEquals:function(obj,value)
        {
            return obj==value;
        },
        JsExactEqualsToUndefined:function(obj)
        {
            return obj===undefined;
        },
        JsExactEquals:function(obj,value)
        {
            return obj===value;
        },
        Typeof:function(obj)
        {
            return typeof(obj);
        },
        ApplyFunction:function(func,thisArg,prms)
        {
            throw $CreateException(new System.NotImplementedException.ctor$$String("TODO: Implement"),new Error());
        },
        CallFunction:function(func,thisArg,prms)
        {
            throw $CreateException(new System.NotImplementedException.ctor$$String("TODO: Implement"),new Error());
        },
        CallFunction2:function(obj,funcName,prms)
        {
            return obj[funcName].apply(obj, Arguments.from(arguments, 2));
        },
        FindOverloadedMethodName:function(obj,funcName)
        {
            funcName+='$$';for(var o in obj)
if (typeof(obj[o])=='function' && o.indexOf(funcName)==0) 
	return o; 
return null;
        },
        Eval:function(code)
        {
            eval(code)
        },
        Compile:function()
        {
            throw $CreateException(new System.NotImplementedException.ctor(),new Error());
        },
        GetHashKey:function(key)
        {
            return JsCompiler.GetHashKey(key);
        },
        DeleteMember:function(obj,name)
        {
            delete obj[name];
        },
        parseFloat:function(s)
        {
            return parseFloat(s);
        },
        parseInt:function(s)
        {
            return parseInt(s);
        },
        ApplyNew:function(jsCtor,prms)
        {
            if(prms==null || prms.length==0) return new jsCtor(); return new jsCtor(prms[0], prms[1], prms[2], prms[3], prms[4], prms[5], prms[6], prms[7], prms[8]);
        },
        IsArray:function(obj)
        {
            return obj instanceof Array;
        },
        isNaN:function(obj)
        {
            return isNaN(obj);
        },
        decodeURIComponent:function(encodedURIString)
        {
            return decodeURIComponent(encodedURIString)
        },
        encodeURIComponent:function(encodedURIString)
        {
            return encodeURIComponent(encodedURIString)
        },
        encodeURI:function(URIString)
        {
            return encodeURI(URIString)
        },
        decodeURI:function(URIString)
        {
            return decodeURI(URIString)
        },
        unescape:function(s)
        {
            return unescape(s)
        }
    },
    assemblyName:"SharpKit.JsClr",
    Kind:"Class",
    definition:
    {
        ctor:function()
        {
            System.Object.ctor.call(this);
        }
    }
};
JsTypes.push(SharpKit$JavaScript$Utils$Js);
var SharpKit$JavaScript$JsNamingHelper=
{
    fullname:"SharpKit.JavaScript.JsNamingHelper",
    baseTypeName:"System.Object",
    staticDefinition:
    {
        JsFunctionNameToClrMethodName:function(jsFuncName)
        {
            var methodName=jsFuncName;
            var di=jsFuncName.indexOf("$");
            if(di > 0)
                methodName = jsFuncName.substr(0,di);
            return methodName;
        },
        ClrTypeToJsTypeRef:function(type)
        {
            var att=System.Linq.Enumerable.FirstOrDefault$1$$IEnumerable$1(SharpKit.JavaScript.JsTypeAttribute,System.Linq.Enumerable.OfType$1(SharpKit.JavaScript.JsTypeAttribute,type.GetCustomAttributes$$Type$$Boolean(Typeof(SharpKit.JavaScript.JsTypeAttribute),false)));
            if(att != null && SharpKit.Extensions2.IsNotNullOrEmpty$$String(att.get_Name()))
            {
                return att.get_Name().Replace$$Char$$Char("`","$");
            }
            return type.get_Namespace() + "." + type.get_Name().Replace$$Char$$Char("`","$");
        },
        ClrConstructorToJsFunctionName:function(mi)
        {
            var sb=new System.Text.StringBuilder.ctor();
            var typeRef=SharpKit.JavaScript.JsNamingHelper.ClrTypeToJsTypeRef(mi.get_DeclaringType());
            sb.Append$$String(typeRef);
            sb.Append$$String(".ctor");
            SharpKit.JavaScript.JsNamingHelper.ConvertParametersToJsFunctionName(mi.GetParameters(),sb);
            return sb.toString();
        },
        ConvertParametersToJsFunctionName:function(prms,sb)
        {
            for(var $i16=0,$l16=prms.length,prm=prms[$i16];$i16 < $l16;$i16++,prm = prms[$i16])
            {
                sb.Append$$String("$$");
                sb.Append$$String(prm.get_ParameterType().get_Name());
            }
        },
        ClrMethodBaseToJsFunctionName:function(mi)
        {
            if(mi.get_MemberType() == 1)
            {
                return SharpKit.JavaScript.JsNamingHelper.ClrMethodToJsFunctionName(Cast(mi,System.Reflection.MethodInfo));
            }
            else if(mi.get_MemberType() == 8)
            {
                return SharpKit.JavaScript.JsNamingHelper.ClrConstructorToJsFunctionName(Cast(mi,System.Reflection.ConstructorInfo));
            }
            else
                throw $CreateException(new System.NotImplementedException.ctor(),new Error());
        },
        ClrMethodToJsFunctionName:function(mi)
        {
            if(SharpKit.JavaScript.JsNamingHelper.IsPropertySetter(mi))
            {
                return mi.get_Name();
            }
            var name=mi.get_Name();
            var type=mi.get_DeclaringType();
            if(type.get_IsGenericType())
            {
                type = type.GetGenericTypeDefinition();
                mi = type.GetMethod$$String(name);
            }
            var sb=new System.Text.StringBuilder.ctor();
            if(mi.get_IsStatic())
            {
                sb.Append$$String(SharpKit.JavaScript.JsNamingHelper.ClrTypeToJsTypeRef(type));
                var att=System.Linq.Enumerable.FirstOrDefault$1$$IEnumerable$1(SharpKit.JavaScript.JsTypeAttribute,System.Linq.Enumerable.OfType$1(SharpKit.JavaScript.JsTypeAttribute,type.GetCustomAttributes$$Type$$Boolean(Typeof(SharpKit.JavaScript.JsTypeAttribute),false)));
                if(att == null || att.get_Mode() == 2)
                {
                    sb.Append$$String(".staticDefinition.");
                }
                else
                {
                    sb.Append$$String(".");
                }
            }
            sb.Append$$String(name);
            SharpKit.JavaScript.JsNamingHelper.ConvertParametersToJsFunctionName(mi.GetParameters(),sb);
            return sb.toString();
        },
        IsPropertySetter:function(mi)
        {
            var name=mi.get_Name();
            return name.StartsWith$$String("set_") && mi.GetParameters().length == 1;
        }
    },
    assemblyName:"SharpKit.JsClr",
    Kind:"Class",
    definition:
    {
        ctor:function()
        {
            System.Object.ctor.call(this);
        }
    }
};
JsTypes.push(SharpKit$JavaScript$JsNamingHelper);