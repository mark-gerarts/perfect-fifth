namespace P5

module Image =

    open Fable.Core
    open P5.Core
    open Color
    open DOM
    open Rendering

    type ImageFilter =
        | Threshold of float
        | Gray
        | Opaque
        | Invert
        | Posterize of float
        | Blur of float
        | Erode
        | Dilate

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
        member _.setPixel (x: float) (y: float) (c: P5Color) : Unit = jsNative

        member self.set (x: float) (y: float) (c: P5Color) = self.setPixel

        [<Emit("$0.resize($1, $2)")>]
        member _.resize (width: float) (height: float) : Unit = jsNative

        [<Emit("$0.copy($1, $2, $3, $4, $5, $6, $7, $8, $9)")>]
        member _.copyFrom
            (img: P5Image)
            (sx: float)
            (sy: float)
            (sw: float)
            (sh: float)
            (dx: float)
            (dy: float)
            (dw: float)
            (dh: float)
            : Unit =
            jsNative

        [<Emit("$0.copy($1, $2, $3, $4, $5, $6, $7, $8)")>]
        member _.copy
            (sx: float)
            (sy: float)
            (sw: float)
            (sh: float)
            (dx: float)
            (dy: float)
            (dw: float)
            (dh: float)
            : Unit =
            jsNative

        [<Emit("$0.mask($1)")>]
        member _.mask(sourceImage: P5Image) : Unit = jsNative

        [<Emit("$0.filter($1)")>]
        member private _.filterNoParam(filter: string) : Unit = jsNative

        [<Emit("$0.filter($1, $2)")>]
        member private _.filterParam (filter: string) (param: float) : Unit = jsNative

        member self.filter(filter: ImageFilter) : Unit =
            match filter with
            | Threshold t -> self.filterParam "threshold" t
            | Gray -> self.filterNoParam "gray"
            | Opaque -> self.filterNoParam "opaque"
            | Invert -> self.filterNoParam "invert"
            | Posterize p -> self.filterParam "posterize" p
            | Blur b -> self.filterParam "blur" b
            | Erode -> self.filterNoParam "erode"
            | Dilate -> self.filterNoParam "dilate"

        [<Emit("$0.blend($1, $2, $3, $4, $5, $6, $7, $8, $9, $10)")>]
        member private _.blendFrom_
            (srcImage: P5Image)
            (sx: float)
            (sy: float)
            (sw: float)
            (sh: float)
            (dx: float)
            (dy: float)
            (dw: float)
            (dh: float)
            (blendMode: string)
            : Unit =
            jsNative

        member self.blendFrom
            (srcImage: P5Image)
            (sx: float)
            (sy: float)
            (sw: float)
            (sh: float)
            (dx: float)
            (dy: float)
            (dw: float)
            (dh: float)
            (blendMode: BlendMode)
            : Unit =
            self.blendFrom_ srcImage sx sy sw sh dx dy dw dh (rawBlendMode blendMode)

        [<Emit("$0.blend($1, $2, $3, $4, $5, $6, $7, $8, $9)")>]
        member private _.blend_
            (sx: float)
            (sy: float)
            (sw: float)
            (sh: float)
            (dx: float)
            (dy: float)
            (dw: float)
            (dh: float)
            (blendMode: string)
            : Unit =
            jsNative

        member self.blend
            (sx: float)
            (sy: float)
            (sw: float)
            (sh: float)
            (dx: float)
            (dy: float)
            (dw: float)
            (dh: float)
            (blendMode: BlendMode)
            : Unit =
            self.blend_ sx sy sw sh dx dy dw dh (rawBlendMode blendMode)

        [<Emit("$0.save($1, $2)")>]
        member _.save (filename: string) (extension: string) : Unit = jsNative

        [<Emit("$0.reset()")>]
        member _.reset() : Unit = jsNative

        [<Emit("$0.getCurrentFrame()")>]
        member _.getCurrentFrame() : int = jsNative

        [<Emit("$0.setFrame($1)")>]
        member _.setFrame(frame: int) : Unit = jsNative

        [<Emit("$0.numFrames()")>]
        member _.numFrames() : int = jsNative

        [<Emit("$0.pause()")>]
        member _.pause() : Unit = jsNative

        [<Emit("$0.play()")>]
        member _.play() : Unit = jsNative

        [<Emit("$0.delay($1)")>]
        member _.delay(ms: float) : Unit = jsNative

        [<Emit("$0.delay($1, $2)")>]
        member _.delayAtIndex (ms: float) (index: int) : Unit = jsNative

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
