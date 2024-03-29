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

        [<Emit("$0.set($1, $2, $3)")>]
        member _.setImage (x: float) (y: float) (img: P5Image) : Unit = jsNative

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

    [<Emit("$0.image($1, $2, $3)")>]
    let image (p5: P5) (image: IImage) (x: float) (y: float) : Unit = jsNative

    [<Emit("$0.image($1, $2, $3, $4, $5)")>]
    let imageWithSize (p5: P5) (image: IImage) (x: float) (y: float) (width: float) (height: float) : Unit = jsNative

    type FitType =
        | Contain
        | Cover

    let private rawFitType fitType =
        match fitType with
        | Contain -> "contain"
        | Cover -> "cover"

    type ImageAlignX =
        | ImageAlignXLeft
        | ImageAlignXCenter
        | ImageAlignXRight

    let private rawImageAlignX align =
        match align with
        | ImageAlignXLeft -> "left"
        | ImageAlignXCenter -> "center"
        | ImageAlignXRight -> "right"

    type ImageAlignY =
        | ImageAlignYTop
        | ImageAlignYCenter
        | ImageAlignYBottom

    let private rawImageAlignY align =
        match align with
        | ImageAlignYTop -> "top"
        | ImageAlignYCenter -> "center"
        | ImageAlignYBottom -> "bottom"

    type ImageOptions =
        { dx: float
          dy: float
          dWidth: float
          dHeight: float
          sx: float
          sy: float
          sWidth: float option
          sHeight: float option
          fit: FitType
          xAlign: ImageAlignX
          yAlign: ImageAlignY }

    let imageOptions dx dy dWidth dHeight sx sy =
        { dx = dx
          dy = dy
          dWidth = dWidth
          dHeight = dHeight
          sx = sx
          sy = sy
          sWidth = None
          sHeight = None
          fit = Contain
          xAlign = ImageAlignXCenter
          yAlign = ImageAlignYCenter }

    [<Emit("$0.image($1, $2, $3, $4, $5, $6, $7, $8, $9, $10, $11, $12)")>]
    let private imageWithOptions_
        (p5: P5)
        (image: IImage)
        (dx: float)
        (dy: float)
        (dWidth: float)
        (dHeight: float)
        (sx: float)
        (sy: float)
        (sWidth: obj)
        (sHeight: obj)
        (fit: string)
        (xAlign: string)
        (yAlign: string)
        =
        jsNative

    let imageWithOptions (p5: P5) (image: IImage) (options: ImageOptions) : Unit =
        imageWithOptions_
            p5
            image
            options.dx
            options.dy
            options.dWidth
            options.dHeight
            options.sx
            options.sy
            (Option.toNullable options.sWidth)
            (Option.toNullable options.sHeight)
            (rawFitType options.fit)
            (rawImageAlignX options.xAlign)
            (rawImageAlignY options.yAlign)

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

    [<Emit("$0.saveGif($1, $2)")>]
    let saveGif (p5: P5) (filename: string) (duration: float) : Unit = jsNative

    type DelayUnit =
        | Seconds
        | Frames

    [<Emit("$0.saveGif($1, $2, $3)")>]
    let private saveGifWithDelay_ (p5: P5) (filename: string) (duration: float) (delay: obj) : Unit = jsNative

    let saveGifWithDelay
        (p5: P5)
        (filename: string)
        (duration: float)
        (delayAmount: float)
        (delayUnit: DelayUnit)
        : Unit =
        let rawUnit =
            match delayUnit with
            | Seconds -> "seconds"
            | Frames -> "frames"

        saveGifWithDelay_
            p5
            filename
            duration
            {| delay = delayAmount
               unit = rawUnit |}

    let tint (p5: P5) (color: Color) : Unit = emitColorFunction p5 "tint" color

    [<Emit("$0.noTint()")>]
    let noTint (p5: P5) : Unit = jsNative

    type ImageMode =
        | Center
        | Corner
        | Corners

    let private rawImageMode (mode: ImageMode) : string =
        match mode with
        | Center -> "center"
        | Corner -> "corner"
        | Corners -> "corners"

    [<Emit("$0.imageMode($1)")>]
    let private imageMode_ (p5: P5) (mode: string) = jsNative

    let imageMode (p5: P5) (mode: ImageMode) = imageMode_ p5 (rawImageMode mode)

    [<Emit("$0.pixels")>]
    let pixels (p5: P5) : float array = jsNative

    [<Emit("$0.loadPixels()")>]
    let loadPixels (p5: P5) : Unit = jsNative

    [<Emit("$0.updatePixels()")>]
    let updatePixels (p5: P5) : Unit = jsNative

    [<Emit("$0.updatePixels($1, $2, $3, $4)")>]
    let updatePixelRegion (p5: P5) (x: float) (y: float) (w: float) (h: float) : Unit = jsNative

    [<Emit("$0.blend($1, $2, $3, $4, $5, $6, $7, $8, $9, $10)")>]
    let private blendFrom_
        (p5: P5)
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

    let blendFrom
        (p5: P5)
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
        blendFrom_ p5 srcImage sx sy sw sh dx dy dw dh (rawBlendMode blendMode)

    [<Emit("$0.blend($1, $2, $3, $4, $5, $6, $7, $8, $9)")>]
    let private blend_
        (p5: P5)
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

    let blend
        (p5: P5)
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
        blend_ p5 sx sy sw sh dx dy dw dh (rawBlendMode blendMode)

    [<Emit("$0.copy($1, $2, $3, $4, $5, $6, $7, $8, $9)")>]
    let copyFrom
        (p5: P5)
        (srcImage: P5Image)
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
    let copy
        (p5: P5)
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

    [<Emit("$0.filter($1)")>]
    let private filterNoParam (p5: P5) (filter: string) : Unit = jsNative

    [<Emit("$0.filter($1, $2)")>]
    let private filterParam (p5: P5) (filter: string) (param: float) : Unit = jsNative

    let filter (p5: P5) (filter: ImageFilter) : Unit =
        match filter with
        | Threshold t -> filterParam p5 "threshold" t
        | Gray -> filterNoParam p5 "gray"
        | Opaque -> filterNoParam p5 "opaque"
        | Invert -> filterNoParam p5 "invert"
        | Posterize p -> filterParam p5 "posterize" p
        | Blur b -> filterParam p5 "blur" b
        | Erode -> filterNoParam p5 "erode"
        | Dilate -> filterNoParam p5 "dilate"

    [<Emit("$0.get()")>]
    let getImage (p5: P5) = jsNative

    [<Emit("$0.get($1, $2, $3, $4)")>]
    let getRegion (p5: P5) (x: float) (y: float) (w: float) (h: float) : P5Image = jsNative

    [<Emit("$0.get($1, $2)")>]
    let getPixel (p5: P5) (x: float) (y: float) : float array = jsNative

    [<Emit("$0.set($1, $2, $3)")>]
    let private setPixel_ (p5: P5) (x: float) (y: float) (c: P5Color) : Unit = jsNative

    let setPixel (p5: P5) (x: float) (y: float) (c: Color) : Unit = setPixel_ p5 x y (ensureP5Color p5 c)

    [<Emit("$0.set($1, $2, $3)")>]
    let setImage (p5: P5) (x: float) (y: float) (image: P5Image) : Unit = jsNative
