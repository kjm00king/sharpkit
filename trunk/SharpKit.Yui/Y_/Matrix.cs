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
    /// Matrix is a class that allows for the manipulation of a transform matrix.
    /// This class is a work in progress.
    /// </summary>
    public partial class Matrix
    {
        /// <summary>
        /// Parses a string and updates the matrix.
        /// </summary>
        public void applyCSSText(object val){}
        /// <summary>
        /// Returns an array of transform commands that represent the matrix.
        /// </summary>
        public Y_.Array decompose(){return null;}
        /// <summary>
        /// Converts a degree value to a radian.
        /// </summary>
        public Y_.DataType_.Number deg2rad(Y_.DataType_.Number deg){return null;}
        /// <summary>
        /// Returns the left, top, right and bottom coordinates for a transformed
        /// item.
        /// </summary>
        public object getContentRect(Y_.DataType_.Number width, Y_.DataType_.Number height, Y_.DataType_.Number x, Y_.DataType_.Number y){return null;}
        /// <summary>
        /// Returns the determinant of the matrix.
        /// </summary>
        public Y_.DataType_.Number getDeterminant(){return null;}
        /// <summary>
        /// Returns a 3x3 Matrix array
        /// /                                             \
        /// | matrix[0][0]   matrix[1][0]    matrix[2][0] |
        /// | matrix[0][1]   matrix[1][1]    matrix[2][1] |
        /// | matrix[0][2]   matrix[1][2]    matrix[2][2] |
        /// \                                             /
        /// </summary>
        public Y_.Array getMatrixArray(){return null;}
        /// <summary>
        /// Parses a string and returns an array of transform arrays.
        /// </summary>
        public Y_.Array getTransformArray(object val){return null;}
        /// <summary>
        /// Returns an identity matrix.
        /// </summary>
        public object identity(){return null;}
        /// <summary>
        /// Initializes a matrix.
        /// </summary>
        public void init(object config){}
        /// <summary>
        /// Returns the inverse (in array form) of the matrix.
        /// </summary>
        public Y_.Array inverse(){return null;}
        /// <summary>
        /// Updates the matrix.
        /// </summary>
        public void multiple(Y_.DataType_.Number a, Y_.DataType_.Number b, Y_.DataType_.Number c, Y_.DataType_.Number d, Y_.DataType_.Number dx, Y_.DataType_.Number dy){}
        /// <summary>
        /// Converts a radian value to a degree.
        /// </summary>
        public Y_.DataType_.Number rad2deg(Y_.DataType_.Number rad){return null;}
        /// <summary>
        /// Applies a rotate transform.
        /// </summary>
        public void rotate(Y_.DataType_.Number deg){}
        /// <summary>
        /// Applies a scale transform
        /// </summary>
        public void scale(Y_.DataType_.Number val){}
        /// <summary>
        /// Applies a skew transformation.
        /// </summary>
        public void skew(Y_.DataType_.Number x, Y_.DataType_.Number y){}
        /// <summary>
        /// Applies a skew to the x-coordinate
        /// </summary>
        public void skewX(Y_.DataType_.Number x){}
        /// <summary>
        /// Applies a skew to the y-coordinate
        /// </summary>
        public void skewY(Y_.DataType_.Number y){}
        /// <summary>
        /// Returns a string of text that can be used to populate a the css transform property of an element.
        /// </summary>
        public object toCSSText(){return null;}
        /// <summary>
        /// Returns a string that can be used to populate the css filter property of an element.
        /// </summary>
        public object toFilterText(){return null;}
        /// <summary>
        /// Applies translate transformation.
        /// </summary>
        public void translate(Y_.DataType_.Number x, Y_.DataType_.Number y){}
        /// <summary>
        /// Returns the transpose of the matrix
        /// </summary>
        public Y_.Array transpose(){return null;}
    }
}