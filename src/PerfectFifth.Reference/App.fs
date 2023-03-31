module P5Reference.App

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
    | "Shape/BeginContour" -> Shape.BeginContour.run node
    | "Shape/BeginShape0" -> Shape.BeginShape0.run node
    | "Shape/BeginShape1" -> Shape.BeginShape1.run node
    | "Shape/BeginShape2" -> Shape.BeginShape2.run node
    | "Shape/BeginShape3" -> Shape.BeginShape3.run node
    | "Shape/BeginShape4" -> Shape.BeginShape4.run node
    | "Shape/BeginShape5" -> Shape.BeginShape5.run node
    | "Shape/BeginShape6" -> Shape.BeginShape6.run node
    | "Shape/BeginShape7" -> Shape.BeginShape7.run node
    | "Shape/BeginShape8" -> Shape.BeginShape8.run node
    | "Shape/BeginShape9" -> Shape.BeginShape9.run node
    | "Shape/BeginShape10" -> Shape.BeginShape10.run node
    | "Shape/BezierVertex0" -> Shape.BezierVertex0.run node
    | "Shape/BezierVertex1" -> Shape.BezierVertex1.run node
    | "Shape/BezierVertex2" -> Shape.BezierVertex2.run node
    | "Shape/CurveVertex" -> Shape.CurveVertex.run node
    | "Shape/EndShape" -> Shape.EndShape.run node
    | "Shape/QuadraticVertex0" -> Shape.QuadraticVertex0.run node
    | "Shape/QuadraticVertex1" -> Shape.QuadraticVertex1.run node
    | "Shape/Vertex0" -> Shape.Vertex0.run node
    | "Shape/Vertex1" -> Shape.Vertex1.run node
    | "Shape/Vertex2" -> Shape.Vertex2.run node
    | "Shape/Vertex3" -> Shape.Vertex3.run node
    | "Shape/Vertex4" -> Shape.Vertex4.run node
    | "Shape/Normal" -> Shape.Normal.run node
    | "Shape/Plane" -> Shape.Plane.run node
    | "Shape/Box" -> Shape.Box.run node
    | "Shape/Sphere0" -> Shape.Sphere0.run node
    | "Shape/Sphere1" -> Shape.Sphere1.run node
    | "Shape/Sphere2" -> Shape.Sphere2.run node
    | "Shape/Cylinder0" -> Shape.Cylinder0.run node
    | "Shape/Cylinder1" -> Shape.Cylinder1.run node
    | "Shape/Cylinder2" -> Shape.Cylinder2.run node
    | "Shape/Cone0" -> Shape.Cone0.run node
    | "Shape/Cone1" -> Shape.Cone1.run node
    | "Shape/Cone2" -> Shape.Cone2.run node
    | "Shape/Ellipsoid0" -> Shape.Ellipsoid0.run node
    | "Shape/Ellipsoid1" -> Shape.Ellipsoid1.run node
    | "Shape/Ellipsoid2" -> Shape.Ellipsoid2.run node
    | "Shape/Torus0" -> Shape.Torus0.run node
    | "Shape/Torus1" -> Shape.Torus1.run node
    | "Shape/Torus2" -> Shape.Torus2.run node
    | "Shape/LoadModel" -> Shape.LoadModel.run node
    | "Shape/Model" -> Shape.Model.run node
    | "Structure/Preload" -> Structure.Preload.run node
    | "Structure/Setup" -> Structure.Setup.run node
    | "Structure/Draw" -> Structure.Draw.run node
    | "Structure/Remove" -> Structure.Remove.run node
    | "Structure/DisableFriendlyErrors" -> Structure.DisableFriendlyErrors.run node
    | "Structure/NoLoop0" -> Structure.NoLoop0.run node
    | "Structure/NoLoop1" -> Structure.NoLoop1.run node
    | "Structure/IsLooping" -> Structure.IsLooping.run node
    | "Structure/Push0" -> Structure.Push0.run node
    | "Structure/Push1" -> Structure.Push1.run node
    | "Structure/Redraw0" -> Structure.Redraw0.run node
    | "Structure/Redraw1" -> Structure.Redraw1.run node
    | "Structure/Subscriptions" -> Structure.Subscriptions.run node
    | "DOM/P5ElementElt" -> DOM.P5ElementElt.run node
    | "DOM/P5ElementParent" -> DOM.P5ElementParent.run node
    | "DOM/P5ElementId" -> DOM.P5ElementId.run node
    | "DOM/P5ElementClass" -> DOM.P5ElementClass.run node
    | "DOM/P5ElementMousePressed" -> DOM.P5ElementMousePressed.run node
    | "DOM/P5ElementDoubleClicked" -> DOM.P5ElementDoubleClicked.run node
    | "DOM/P5ElementMouseWheel" -> DOM.P5ElementMouseWheel.run node
    | "DOM/P5ElementMouseReleased" -> DOM.P5ElementMouseReleased.run node
    | "DOM/P5ElementMouseClicked" -> DOM.P5ElementMouseClicked.run node
    | "DOM/P5ElementMouseMoved" -> DOM.P5ElementMouseMoved.run node
    | "DOM/P5ElementMouseOver" -> DOM.P5ElementMouseOver.run node
    | "DOM/P5ElementMouseOut" -> DOM.P5ElementMouseOut.run node
    | "DOM/P5ElementTouchStarted" -> DOM.P5ElementTouchStarted.run node
    | "DOM/P5ElementTouchMoved" -> DOM.P5ElementTouchMoved.run node
    | "DOM/P5ElementTouchEnded" -> DOM.P5ElementTouchEnded.run node
    | "DOM/P5ElementDragOver" -> DOM.P5ElementDragOver.run node
    | "DOM/P5ElementDragLeave" -> DOM.P5ElementDragLeave.run node
    | "DOM/P5ElementAddClass" -> DOM.P5ElementAddClass.run node
    | "DOM/P5ElementRemoveClass" -> DOM.P5ElementRemoveClass.run node
    | "DOM/P5ElementHasClass" -> DOM.P5ElementHasClass.run node
    | "DOM/P5ElementToggleClass" -> DOM.P5ElementToggleClass.run node
    | "DOM/P5ElementChild" -> DOM.P5ElementChild.run node
    | "DOM/P5ElementCenter" -> DOM.P5ElementCenter.run node
    | "DOM/P5ElementHtml" -> DOM.P5ElementHtml.run node
    | "DOM/P5ElementPosition" -> DOM.P5ElementPosition.run node
    | "DOM/P5ElementStyle0" -> DOM.P5ElementStyle0.run node
    | "DOM/P5ElementStyle1" -> DOM.P5ElementStyle1.run node
    | "DOM/P5ElementStyle2" -> DOM.P5ElementStyle2.run node
    | "DOM/P5ElementAttribute" -> DOM.P5ElementAttribute.run node
    | "DOM/P5ElementRemoveAttribute" -> DOM.P5ElementRemoveAttribute.run node
    | "DOM/P5ElementValue" -> DOM.P5ElementValue.run node
    | "DOM/P5ElementShow" -> DOM.P5ElementShow.run node
    | "DOM/P5ElementHide" -> DOM.P5ElementHide.run node
    | "DOM/P5ElementSize" -> DOM.P5ElementSize.run node
    | "DOM/P5ElementRemove" -> DOM.P5ElementRemove.run node
    | "DOM/P5ElementDrop" -> DOM.P5ElementDrop.run node
    | "DOM/Select" -> DOM.Select.run node
    | "DOM/SelectAll0" -> DOM.SelectAll0.run node
    | "DOM/SelectAll1" -> DOM.SelectAll1.run node
    | "DOM/RemoveElements" -> DOM.RemoveElements.run node
    | "DOM/Changed0" -> DOM.Changed0.run node
    | "DOM/Changed1" -> DOM.Changed1.run node
    | "DOM/Input" -> DOM.Input.run node
    | "DOM/CreateDiv" -> DOM.CreateDiv.run node
    | "DOM/CreateP" -> DOM.CreateP.run node
    | "DOM/CreateSpan" -> DOM.CreateSpan.run node
    | "DOM/CreateImg" -> DOM.CreateImg.run node
    | "DOM/CreateA" -> DOM.CreateA.run node
    | "DOM/CreateSlider0" -> DOM.CreateSlider0.run node
    | "DOM/CreateSlider1" -> DOM.CreateSlider1.run node
    | "DOM/CreateButton" -> DOM.CreateButton.run node
    | "DOM/CreateCheckbox" -> DOM.CreateCheckbox.run node
    | "DOM/CreateSelect0" -> DOM.CreateSelect0.run node
    | "DOM/CreateSelect1" -> DOM.CreateSelect1.run node
    | "DOM/CreateRadio0" -> DOM.CreateRadio0.run node
    | "DOM/CreateRadio1" -> DOM.CreateRadio1.run node
    | "DOM/CreateColorPicker0" -> DOM.CreateColorPicker0.run node
    | "DOM/CreateColorPicker1" -> DOM.CreateColorPicker1.run node
    | "DOM/CreateInput" -> DOM.CreateInput.run node
    | "DOM/CreateFileInput" -> DOM.CreateFileInput.run node
    | "DOM/CreateVideo" -> DOM.CreateVideo.run node
    | "DOM/CreateAudio" -> DOM.CreateAudio.run node
    | "DOM/CreateCapture0" -> DOM.CreateCapture0.run node
    | "DOM/CreateCapture1" -> DOM.CreateCapture1.run node
    | "DOM/CreateCapture2" -> DOM.CreateCapture2.run node
    | "DOM/CreateElement" -> DOM.CreateElement.run node
    | "DOM/P5MediaElementSrc" -> DOM.P5MediaElementSrc.run node
    | "DOM/P5MediaElementPlay" -> DOM.P5MediaElementPlay.run node
    | "DOM/P5MediaElementStop" -> DOM.P5MediaElementStop.run node
    | "DOM/P5MediaElementPause" -> DOM.P5MediaElementPause.run node
    | "DOM/P5MediaElementLoop" -> DOM.P5MediaElementLoop.run node
    | "DOM/P5MediaElementNoLoop" -> DOM.P5MediaElementNoLoop.run node
    | "DOM/P5MediaElementAutoPlay0" -> DOM.P5MediaElementAutoPlay0.run node
    | "DOM/P5MediaElementAutoPlay1" -> DOM.P5MediaElementAutoPlay1.run node
    | "DOM/P5MediaElementVolume0" -> DOM.P5MediaElementVolume0.run node
    | "DOM/P5MediaElementVolume1" -> DOM.P5MediaElementVolume1.run node
    | "DOM/P5MediaElementSpeed" -> DOM.P5MediaElementSpeed.run node
    | "DOM/P5MediaElementDuration" -> DOM.P5MediaElementDuration.run node
    | "DOM/P5MediaElementOnEnded" -> DOM.P5MediaElementOnEnded.run node
    | "DOM/P5MediaElementShowControls" -> DOM.P5MediaElementShowControls.run node
    | "DOM/P5MediaElementHideControls" -> DOM.P5MediaElementHideControls.run node
    | "DOM/P5MediaElementAddCue" -> DOM.P5MediaElementAddCue.run node
    | "DOM/P5MediaElementRemoveCue" -> DOM.P5MediaElementRemoveCue.run node
    | "DOM/P5MediaElementClearCues" -> DOM.P5MediaElementClearCues.run node
    | "DOM/P5File" -> DOM.P5File.run node
    | "Rendering/P5GraphicsReset" -> Rendering.P5GraphicsReset.run node
    | "Rendering/P5GraphicsRemove0" -> Rendering.P5GraphicsRemove0.run node
    | "Rendering/P5GraphicsRemove1" -> Rendering.P5GraphicsRemove1.run node
    | "Rendering/CreateCanvas" -> Rendering.CreateCanvas.run node
    | "Rendering/ResizeCanvas" -> Rendering.ResizeCanvas.run node
    | "Rendering/NoCanvas" -> Rendering.NoCanvas.run node
    | "Rendering/CreateGraphics" -> Rendering.CreateGraphics.run node
    | "Rendering/BlendMode0" -> Rendering.BlendMode0.run node
    | "Rendering/BlendMode1" -> Rendering.BlendMode1.run node
    | "Rendering/DrawingContext" -> Rendering.DrawingContext.run node
    | "Rendering/SetAttributes0" -> Rendering.SetAttributes0.run node
    | "Rendering/SetAttributes1" -> Rendering.SetAttributes1.run node
    | "Rendering/SetAttributes2" -> Rendering.SetAttributes2.run node
    | "Transform/ApplyMatrix0" -> Transform.ApplyMatrix0.run node
    | "Transform/ApplyMatrix1" -> Transform.ApplyMatrix1.run node
    | "Transform/ApplyMatrix2" -> Transform.ApplyMatrix2.run node
    | "Transform/ApplyMatrix3" -> Transform.ApplyMatrix3.run node
    | "Transform/ApplyMatrix4" -> Transform.ApplyMatrix4.run node
    | "Transform/ApplyMatrix5" -> Transform.ApplyMatrix5.run node
    | "Transform/ResetMatrix" -> Transform.ResetMatrix.run node
    | "Transform/Rotate" -> Transform.Rotate.run node
    | "Transform/RotateX" -> Transform.RotateX.run node
    | "Transform/RotateY" -> Transform.RotateY.run node
    | "Transform/RotateZ" -> Transform.RotateZ.run node
    | "Transform/Scale0" -> Transform.Scale0.run node
    | "Transform/Scale1" -> Transform.Scale1.run node
    | "Transform/ShearX" -> Transform.ShearX.run node
    | "Transform/ShearY" -> Transform.ShearY.run node
    | "Transform/Translate0" -> Transform.Translate0.run node
    | "Transform/Translate1" -> Transform.Translate1.run node
    | "Transform/Translate2" -> Transform.Translate2.run node
    | "Events/AccelerationX" -> Events.AccelerationX.run node
    | "Events/AccelerationY" -> Events.AccelerationY.run node
    | "Events/AccelerationZ" -> Events.AccelerationZ.run node
    | "Events/RotationX" -> Events.RotationX.run node
    | "Events/RotationY" -> Events.RotationY.run node
    | "Events/RotationZ" -> Events.RotationZ.run node
    | "Events/PRotationX" -> Events.PRotationX.run node
    | "Events/PRotationY" -> Events.PRotationY.run node
    | "Events/PRotationZ" -> Events.PRotationZ.run node
    | "Events/TurnAxis" -> Events.TurnAxis.run node
    | "Events/SetMoveTreshold" -> Events.SetMoveTreshold.run node
    | "Events/SetShakeTreshold" -> Events.SetShakeTreshold.run node
    | "Events/DeviceMoved" -> Events.DeviceMoved.run node
    | "Events/DeviceTurned" -> Events.DeviceTurned.run node
    | "Events/DeviceShaken" -> Events.DeviceShaken.run node
    | "Events/KeyIsPressed" -> Events.KeyIsPressed.run node
    | "Events/Key" -> Events.Key.run node
    | "Events/KeyCode0" -> Events.KeyCode0.run node
    | "Events/KeyCode1" -> Events.KeyCode1.run node
    | "Events/KeyPressed0" -> Events.KeyPressed0.run node
    | "Events/KeyPressed1" -> Events.KeyPressed1.run node
    | "Events/KeyPressed2" -> Events.KeyPressed2.run node
    | "Events/KeyReleased" -> Events.KeyReleased.run node
    | "Events/KeyTyped" -> Events.KeyTyped.run node
    | "Events/KeyIsDown0" -> Events.KeyIsDown0.run node
    | "Events/KeyIsDown1" -> Events.KeyIsDown1.run node
    | "Events/MovedX" -> Events.MovedX.run node
    | "Events/MovedY" -> Events.MovedY.run node
    | "Events/MouseX" -> Events.MouseX.run node
    | "Events/MouseY" -> Events.MouseY.run node
    | "Events/PMouseX" -> Events.PMouseX.run node
    | "Events/PMouseY" -> Events.PMouseY.run node
    | "Events/WinMouseX" -> Events.WinMouseX.run node
    | "Events/WinMouseY" -> Events.WinMouseY.run node
    | "Events/PWinMouseX" -> Events.PWinMouseX.run node
    | "Events/PWinMouseY" -> Events.PWinMouseY.run node
    | "Events/MouseButton" -> Events.MouseButton.run node
    | "Events/MouseIsPressed" -> Events.MouseIsPressed.run node
    | "Events/MouseMoved0" -> Events.MouseMoved0.run node
    | "Events/MouseMoved1" -> Events.MouseMoved1.run node
    | "Events/MouseMoved2" -> Events.MouseMoved2.run node
    | "Events/MouseDragged0" -> Events.MouseDragged0.run node
    | "Events/MouseDragged1" -> Events.MouseDragged1.run node
    | "Events/MouseDragged2" -> Events.MouseDragged2.run node
    | "Events/MousePressed0" -> Events.MousePressed0.run node
    | "Events/MousePressed1" -> Events.MousePressed1.run node
    | "Events/MousePressed2" -> Events.MousePressed2.run node
    | "Events/MouseReleased0" -> Events.MouseReleased0.run node
    | "Events/MouseReleased1" -> Events.MouseReleased1.run node
    | "Events/MouseReleased2" -> Events.MouseReleased2.run node
    | "Events/MouseClicked0" -> Events.MouseClicked0.run node
    | "Events/MouseClicked1" -> Events.MouseClicked1.run node
    | "Events/MouseClicked2" -> Events.MouseClicked2.run node
    | "Events/DoubleClicked0" -> Events.DoubleClicked0.run node
    | "Events/DoubleClicked1" -> Events.DoubleClicked1.run node
    | "Events/DoubleClicked2" -> Events.DoubleClicked2.run node
    | "Events/MouseWheel" -> Events.MouseWheel.run node
    | "Events/RequestPointerLock" -> Events.RequestPointerLock.run node
    | "Events/ExitPointerLock" -> Events.ExitPointerLock.run node
    | "Events/Touches" -> Events.Touches.run node
    | "Events/ToucheStarted0" -> Events.ToucheStarted0.run node
    | "Events/ToucheStarted1" -> Events.ToucheStarted1.run node
    | "Events/ToucheStarted2" -> Events.ToucheStarted2.run node
    | "Events/ToucheMoved0" -> Events.ToucheMoved0.run node
    | "Events/ToucheMoved1" -> Events.ToucheMoved1.run node
    | "Events/ToucheMoved2" -> Events.ToucheMoved2.run node
    | "Events/ToucheEnded0" -> Events.ToucheEnded0.run node
    | "Events/ToucheEnded1" -> Events.ToucheEnded1.run node
    | "Events/ToucheEnded2" -> Events.ToucheEnded2.run node
    | _ -> failwith <| "No sketch with name " + name + " exists"
