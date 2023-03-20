module P5Reference

open Browser.Dom
open P5.Core
open P5Reference

let runSketch name canvasSelector =
    let node = Element <| document.querySelector (canvasSelector)

    // See scripts/generate-reference-sketches.sh
    match name with
    | "Environment/Describe0" -> Environment.Describe0.run node
    | "Environment/Describe1" -> Environment.Describe1.run node
    | "Environment/DescribeElement" -> Environment.DescribeElement.run node
    | "Environment/TextOutput0" -> Environment.TextOutput0.run node
    | "Environment/TextOutput1" -> Environment.TextOutput1.run node
    | "Environment/GridOutput0" -> Environment.GridOutput0.run node
    | "Environment/GridOutput1" -> Environment.GridOutput1.run node
    | "Environment/Print" -> Environment.Print.run node
    | "Environment/FrameCount" -> Environment.FrameCount.run node
    | "Environment/DeltaTime" -> Environment.DeltaTime.run node
    | "Environment/Focused" -> Environment.Focused.run node
    | "Environment/Cursor" -> Environment.Cursor.run node
    | "Environment/FrameRate" -> Environment.FrameRate.run node
    | "Environment/GetTargetFrameRate" -> Environment.GetTargetFrameRate.run node
    | "Environment/NoCursor" -> Environment.NoCursor.run node
    | "Environment/DisplayWidth" -> Environment.DisplayWidth.run node
    | "Environment/WindowWidth" -> Environment.WindowWidth.run node
    | "Environment/WindowResized" -> Environment.WindowResized.run node
    | "Environment/Fullscreen" -> Environment.Fullscreen.run node
    | "Environment/PixelDensity0" -> Environment.PixelDensity0.run node
    | "Environment/PixelDensity1" -> Environment.PixelDensity1.run node
    | "Environment/DisplayDensity" -> Environment.DisplayDensity.run node
    | "Environment/GetUrl" -> Environment.GetUrl.run node
    | "Environment/GetUrlPath" -> Environment.GetUrlPath.run node
    | "Environment/GetUrlParams" -> Environment.GetUrlParams.run node
    | "Color/Alpha" -> Color.Alpha.run node
    | "Color/Background0" -> Color.Background0.run node
    | "Color/Background1" -> Color.Background1.run node
    | "Color/Background2" -> Color.Background2.run node
    | "Color/Background3" -> Color.Background3.run node
    | "Color/Background4" -> Color.Background4.run node
    | "Color/Background5" -> Color.Background5.run node
    | "Color/Background6" -> Color.Background6.run node
    | "Color/Background7" -> Color.Background7.run node
    | "Color/Background8" -> Color.Background8.run node
    | "Color/Background9" -> Color.Background9.run node
    | "Color/Background10" -> Color.Background10.run node
    | "Color/Blue" -> Color.Blue.run node
    | "Color/Brightness0" -> Color.Brightness0.run node
    | "Color/Brightness1" -> Color.Brightness1.run node
    | "Color/Clear" -> Color.Clear.run node
    | "Color/Color0" -> Color.Color0.run node
    | "Color/Color1" -> Color.Color1.run node
    | "Color/Color2" -> Color.Color2.run node
    | "Color/Color3" -> Color.Color3.run node
    | "Color/Color4" -> Color.Color4.run node
    | "Color/Color5" -> Color.Color5.run node
    | "Color/Color6" -> Color.Color6.run node
    | "Color/Color7" -> Color.Color7.run node
    | "Color/ColorMode0" -> Color.ColorMode0.run node
    | "Color/ColorMode1" -> Color.ColorMode1.run node
    | "Color/ColorMode2" -> Color.ColorMode2.run node
    | "Color/ColorMode3" -> Color.ColorMode3.run node
    | "Color/Erase0" -> Color.Erase0.run node
    | "Color/Erase1" -> Color.Erase1.run node
    | "Color/Erase2" -> Color.Erase2.run node
    | "Color/Fill0" -> Color.Fill0.run node
    | "Color/Fill1" -> Color.Fill1.run node
    | "Color/Fill2" -> Color.Fill2.run node
    | "Color/Fill3" -> Color.Fill3.run node
    | "Color/Fill4" -> Color.Fill4.run node
    | "Color/Fill5" -> Color.Fill5.run node
    | "Color/Fill6" -> Color.Fill6.run node
    | "Color/Fill7" -> Color.Fill7.run node
    | "Color/Fill8" -> Color.Fill8.run node
    | "Color/Fill9" -> Color.Fill9.run node
    | "Color/Fill10" -> Color.Fill10.run node
    | "Color/Green" -> Color.Green.run node
    | "Color/Hue" -> Color.Hue.run node
    | "Color/Lightness" -> Color.Lightness.run node
    | "Color/LerpColor" -> Color.LerpColor.run node
    | "Color/NoErase" -> Color.NoErase.run node
    | "Color/NoFill0" -> Color.NoFill0.run node
    | "Color/NoFill1" -> Color.NoFill1.run node
    | "Color/NoStroke0" -> Color.NoStroke0.run node
    | "Color/NoStroke1" -> Color.NoStroke1.run node
    | "Color/P5ColorToString0" -> Color.P5ColorToString0.run node
    | "Color/P5ColorToString1" -> Color.P5ColorToString1.run node
    | "Color/P5ColorSetRed" -> Color.P5ColorSetRed.run node
    | "Color/P5ColorSetGreen" -> Color.P5ColorSetGreen.run node
    | "Color/P5ColorSetBlue" -> Color.P5ColorSetBlue.run node
    | "Color/P5ColorSetAlpha" -> Color.P5ColorSetAlpha.run node
    | "Color/Red" -> Color.Red.run node
    | "Color/Saturation" -> Color.Saturation.run node
    | "Color/Stroke0" -> Color.Stroke0.run node
    | "Color/Stroke1" -> Color.Stroke1.run node
    | "Color/Stroke2" -> Color.Stroke2.run node
    | "Color/Stroke3" -> Color.Stroke3.run node
    | "Color/Stroke4" -> Color.Stroke4.run node
    | "Color/Stroke5" -> Color.Stroke5.run node
    | "Color/Stroke6" -> Color.Stroke6.run node
    | "Color/Stroke7" -> Color.Stroke7.run node
    | "Color/Stroke8" -> Color.Stroke8.run node
    | "Color/Stroke9" -> Color.Stroke9.run node
    | "Color/Stroke10" -> Color.Stroke10.run node
    | "Shape/Arc0" -> Shape.Arc0.run node
    | "Shape/Arc1" -> Shape.Arc1.run node
    | "Shape/Arc2" -> Shape.Arc2.run node
    | "Shape/Arc3" -> Shape.Arc3.run node
    | "Shape/Arc4" -> Shape.Arc4.run node
    | "Shape/Ellipse" -> Shape.Ellipse.run node
    | "Shape/Circle" -> Shape.Circle.run node
    | "Shape/Line0" -> Shape.Line0.run node
    | "Shape/Line1" -> Shape.Line1.run node
    | "Shape/Point0" -> Shape.Point0.run node
    | "Shape/Point1" -> Shape.Point1.run node
    | "Shape/Point2" -> Shape.Point2.run node
    | "Shape/Quad" -> Shape.Quad.run node
    | "Shape/Rect0" -> Shape.Rect0.run node
    | "Shape/Rect1" -> Shape.Rect1.run node
    | "Shape/Rect2" -> Shape.Rect2.run node
    | "Shape/Square0" -> Shape.Square0.run node
    | "Shape/Square1" -> Shape.Square1.run node
    | "Shape/Square2" -> Shape.Square2.run node
    | "Shape/Triangle" -> Shape.Triangle.run node
    | "Shape/EllipseMode0" -> Shape.EllipseMode0.run node
    | "Shape/EllipseMode1" -> Shape.EllipseMode1.run node
    | "Shape/NoSmooth" -> Shape.NoSmooth.run node
    | "Shape/RectMode0" -> Shape.RectMode0.run node
    | "Shape/RectMode1" -> Shape.RectMode1.run node
    | "Shape/StrokeCap" -> Shape.StrokeCap.run node
    | "Shape/StrokeJoin0" -> Shape.StrokeJoin0.run node
    | "Shape/StrokeJoin1" -> Shape.StrokeJoin1.run node
    | "Shape/StrokeJoin2" -> Shape.StrokeJoin2.run node
    | "Shape/StrokeWeight0" -> Shape.StrokeWeight0.run node
    | "Shape/StrokeWeight1" -> Shape.StrokeWeight1.run node
    | "Shape/Bezier0" -> Shape.Bezier0.run node
    | "Shape/Bezier1" -> Shape.Bezier1.run node
    | "Shape/BezierDetail" -> Shape.BezierDetail.run node
    | "Shape/BezierPoint" -> Shape.BezierPoint.run node
    | "Shape/BezierTangent0" -> Shape.BezierTangent0.run node
    | "Shape/BezierTangent1" -> Shape.BezierTangent1.run node
    | "Shape/Curve0" -> Shape.Curve0.run node
    | "Shape/Curve1" -> Shape.Curve1.run node
    | "Shape/Curve2" -> Shape.Curve2.run node
    | "Shape/CurveDetail" -> Shape.CurveDetail.run node
    | "Shape/CurveTightness" -> Shape.CurveTightness.run node
    | "Shape/CurvePoint" -> Shape.CurvePoint.run node
    | "Shape/CurveTangent" -> Shape.CurveTangent.run node
    | _ -> failwith <| "No sketch with name " + name + " exists"
