﻿using System;
    private const int GL_ACCUM = 256;
    private const int GL_RETURN = 258;
    {
        Accum = GL_ACCUM,
        Load = GL_LOAD,
        Return = GL_RETURN,
        Mult = GL_MULT,
        Add = GL_ADD
    }

    private const int GL_POINTS = 0;
    public enum Mode : int
    {
        Points = GL_POINTS,
        Lines = GL_LINES,
        LineLoop = GL_LINE_LOOP,
        LineStrip = GL_LINE_STRIP,
        Triangles = GL_TRIANGLES,
        TrianglesStript = GL_TRIANGLE_STRIP,
        TrianglesFan = GL_TRIANGLE_FAN,
        Quads = GL_QUADS,
        QuadsStript = GL_QUAD_STRIP,
        Polygon = GL_POLYGON
    }

    private const int GL_NEVER = 512;
    public enum Func : int
    {
        Never = GL_NEVER,
        Less = GL_LESS,
        Equal = GL_EQUAL,
        Lequal = GL_LEQUAL,
        Greater = GL_GREATER,
        Notequal = GL_NOTEQUAL,
        Gequal = GL_GEQUAL,
        Always = GL_ALWAYS
    }

    {
        Current = GL_CURRENT_BIT,
        Point = GL_POINT_BIT,
        Line = GL_LINE_BIT,
        Polygon = GL_POLYGON_BIT,
        PolygonStipple = GL_POLYGON_STIPPLE_BIT,
        Pixel = GL_PIXEL_MODE_BIT,
        Lighting = GL_LIGHTING_BIT,
        Log = GL_FOG_BIT,
        Depth = GL_DEPTH_BUFFER_BIT,
        Accum = GL_ACCUM_BUFFER_BIT,
        Stencil = GL_STENCIL_BUFFER_BIT,
        Viewport = GL_VIEWPORT_BIT,
        Transform = GL_TRANSFORM_BIT,
        Enable = GL_ENABLE_BIT,
        Color = GL_COLOR_BUFFER_BIT,
        Hint = GL_HINT_BIT,
        Eval = GL_EVAL_BIT,
        List = GL_LIST_BIT,
        Texture = GL_TEXTURE_BIT,
        Scissor = GL_SCISSOR_BIT,
        All = GL_ALL_ATTRIB_BITS
    }

    private const int GL_ZERO = 0;
    {
        Zero = GL_ZERO,
        One = GL_ONE,
        SrcColor = GL_SRC_COLOR,
        OneMinusSrcColor = GL_ONE_MINUS_SRC_COLOR,
        SrcAlpha = GL_SRC_ALPHA,
        OneMinusSrcAlpha = GL_ONE_MINUS_SRC_ALPHA,
        DstAlpha = GL_DST_ALPHA,
        OneMinusDstAlpha = GL_ONE_MINUS_DST_ALPHA,
        DstColor = GL_DST_COLOR,
        OneMinusDstColor = GL_ONE_MINUS_DST_COLOR,
        SrcAlphaSaturate = GL_SRC_ALPHA_SATURATE
    }

    private const int GL_TRUE = 1;
    {
        True = GL_TRUE, 
        False = GL_FALSE,
    }
    {
        Plane0 = GL_CLIP_PLANE0,
        Plane1 = GL_CLIP_PLANE1,
        Plane2 = GL_CLIP_PLANE2,
        Plane3 = GL_CLIP_PLANE3,
        Plane4 = GL_CLIP_PLANE4,
        Plane5 = GL_CLIP_PLANE5,
    }