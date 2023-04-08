namespace P5

module Image =

    open Fable.Core
    open P5.Core
    open Color
    open DOM

    type P5Image =
        interface IImage

        [<Emit("$0.width")>]
        member _.width: int = jsNative

        [<Emit("$0.height")>]
        member _.height: int = jsNative

        [<Emit("$0.pixels")>]
        member _.pixels: float array = jsNative

        [<Emit("$0.loadPixels()")>]
        member _.loadPixels() : Unit = jsNative

        [<Emit("$0.updatePixels()")>]
        member _.updatePixels() : Unit = jsNative

        [<Emit("$0.get($1, $2, $3, $4)")>]
        member _.getRegion (x: float) (y: float) (w: float) (h: float) : P5Image = jsNative

        [<Emit("$0.get($1, $2)")>]
        member _.getPixel (x: float) (y: float) : float array = jsNative

        /// We only allow P5Colors at the moment, until we find a nice way to do
        /// something similar as emitColorFunction.
        [<Emit("$0.set($1, $2, $3)")>]
        member _.setPixel (x: float) (y: float) (c: P5Color) = jsNative

        member self.set (x: float) (y: float) (c: P5Color) = self.setPixel

    /// TODO: image accepts other values as well; also width and height.
    [<Emit("$0.image($1, $2, $3)")>]
    let image (p5: P5) (image: IImage) (x: float) (y: float) : Unit = jsNative

    [<Emit("$0.image($1, $2, $3, $4, $5)")>]
    let imageWithSize (p5: P5) (image: IImage) (x: float) (y: float) (width: float) (height: float) : Unit = jsNative

    [<Emit("$0.background($1)")>]
    let backgroundImage (p5: P5) (image: P5Image) : Unit = jsNative

    [<Emit("$0.loadImage($1)")>]
    let loadImage (p5: P5) (path: string) : P5Image = jsNative

    [<Emit("$0.loadImage($1, $2, $3)")>]
    let loadImageWithCallbacks (p5: P5) (path: string) (onSuccess: P5Image -> Unit) (onFailure: obj -> Unit) : P5Image =
        jsNative

    [<Emit("$0.createImage($1, $2)")>]
    let createImage (p5: P5) (width: float) (height: float) : P5Image = jsNative

    [<Emit("$0.saveCanvas()")>]
    let saveCanvas (p5: P5) : Unit = jsNative

    [<Emit("$0.saveCanvas($1, $2)")>]
    let saveCanvasAs (p5: P5) (filename: string) (extension: string) : Unit = jsNative

    [<Emit("$0.saveCanvas($1)")>]
    let saveSpecificCanvas (p5: P5) (element: P5Element<'Unit>) : Unit = jsNative

    [<Emit("$0.saveCanvas($1, $2, $3)")>]
    let saveSpecificCanvasAs (p5: P5) (element: P5Element<'Unit>) (filename: string) (extension: string) : Unit =
        jsNative

    [<Emit("$0.saveFrames($1, $2, $3, $4)")>]
    let saveFrames (p5: P5) (filename: string) (extension: string) (duration: float) (framerate: float) : Unit =
        jsNative

    type FrameObject =
        { imageData: string
          filename: string
          extension: string }

    [<Emit("$0.saveFrames($1, $2, $3, $4, $5)")>]
    let saveFramesWithCallback
        (p5: P5)
        (filename: string)
        (extension: string)
        (duration: float)
        (framerate: float)
        (callback: FrameObject array -> Unit)
        : Unit =
        jsNative
