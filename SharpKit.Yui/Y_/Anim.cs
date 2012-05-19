//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace Y_
{
    /// <summary>
    /// A class for constructing animation instances.
    /// </summary>
    public partial class Anim : Y_.Base
    {
        [JsMethod(JsonInitializers=true)]
        public Anim(){}
        /// <summary>
        /// Get the current position of the animated element based on t.
        /// Each point is an array of "x" and "y" values (0 = x, 1 = y)
        /// At least 2 points are required (start and end).
        /// First point is start. Last point is end.
        /// Additional control points are optional.
        /// </summary>
        public Y_.Array getBezier(Y_.Array points, Y_.DataType_.Number t){return null;}
        /// <summary>
        /// Pauses all animation instances.
        /// </summary>
        public void pause(){}
        /// <summary>
        /// Runs all animation instances.
        /// </summary>
        public void run(){}
        /// <summary>
        /// Stops all animation instances.
        /// </summary>
        public void stop(){}
        /// <summary>
        /// Stops the animation and resets its time.
        /// </summary>
        public void stop(object finish){}
        /// <summary>
        /// Bucket for custom getters and setters
        /// </summary>
        public object behaviors{get;set;}
        /// <summary>
        /// The default getter to use when getting object properties.
        /// </summary>
        public object DEFAULT_GETTER{get;set;}
        /// <summary>
        /// The default setter to use when setting object properties.
        /// </summary>
        public object DEFAULT_SETTER{get;set;}
        /// <summary>
        /// The default unit to use with properties that pass the RE_DEFAULT_UNIT test.
        /// </summary>
        public object DEFAULT_UNIT{get;set;}
        /// <summary>
        /// The method that will provide values to the attribute(s) during the animation.
        /// Defaults to "Easing.easeNone".
        /// </summary>
        public JsAction easing{get;set;}
        /// <summary>
        /// The starting values for the animated properties.
        /// Fields may be strings, numbers, or functions.
        /// If a function is used, the return value becomes the from value.
        /// If no from value is specified, the DEFAULT_GETTER will be used.
        /// Supports any unit, provided it matches the "to" (or default)
        /// unit (e.g. `{width: '10em', color: 'rgb(0, 0 0)', borderColor: '#ccc'}`).
        /// If using the default ('px' for length-based units), the unit may be omitted
        /// (e.g. `{width: 100}, borderColor: 'ccc'}`, which defaults to pixels
        /// and hex, respectively).
        /// </summary>
        public object from{get;set;}
        /// <summary>
        /// Time in milliseconds passed to setInterval for frame processing
        /// </summary>
        public object intervalTime{get;set;}
        /// <summary>
        /// The object to be animated.
        /// </summary>
        public Node node{get;set;}
        /// <summary>
        /// Regex of properties that should use the default unit.
        /// </summary>
        public object RE_DEFAULT_UNIT{get;set;}
        /// <summary>
        /// The ending values for the animated properties.
        /// Fields may be strings, numbers, or functions.
        /// Supports any unit, provided it matches the "from" (or default)
        /// unit (e.g. `{width: '50%', color: 'red', borderColor: '#ccc'}`).
        /// If using the default ('px' for length-based units), the unit may be omitted
        /// (e.g. `{width: 100, borderColor: 'ccc'}`, which defaults to pixels
        /// and hex, respectively).
        /// </summary>
        public object to{get;set;}
    }
}