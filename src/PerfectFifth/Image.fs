namespace P5

module Image =

    open Fable.Core
    open P5.Core

    type P5Image =
        interface IImage

        [<Emit("$0.width")>]
        member _.width: int = jsNative

        [<Emit("$0.height")>]
        member _.height: int = jsNative

        [<Emit("$0.loadPixels()")>]
        member _.loadPixels() : Unit = jsNative

        [<Emit("$0.get($1, $2, $3, $4)")>]
        member _.getRegion (x: float) (y: float) (w: float) (h: float) : P5Image = jsNative

        [<Emit("$0.get($1, $2)")>]
        member _.getPixel (x: float) (y: float) : float array = jsNative

    /// TODO: image accepts other values as well; also width and height.
    [<Emit("$0.image($1, $2, $3)")>]
    let image (p5: P5) (image: IImage) (x: float) (y: float) : Unit = jsNative

    [<Emit("$0.image($1, $2, $3, $4, $5)")>]
    let imageWithSize (p5: P5) (image: IImage) (x: float) (y: float) (width: float) (height: float) : Unit = jsNative

    [<Emit("$0.loadImage($1)")>]
    let loadImage (p5: P5) (path: string) : P5Image = jsNative

    [<Emit("$0.loadImage($1, $2, $3)")>]
    let loadImageWithCallbacks (p5: P5) (path: string) (onSuccess: P5Image -> Unit) (onFailure: obj -> Unit) : P5Image =
        jsNative
