namespace P5

module Math =

    open P5.Core
    open Fable.Core
    open Fable.Core.JsInterop

    let pi = 3.141592653589793

    let twoPi = 6.283185307179586

    let halfPi = 1.5707963267948966

    let quarterPi = 0.7853981633974483

    let tau = 6.283185307179586

    [<Emit("$0.map($1, $2, $3, $4, $5)")>]
    let map (p5: P5) (value: float) (start1: float) (stop1: float) (start2: float) (stop2: float) : float = jsNative

    [<Emit("$0.map($1, $2, $3, $4, $5, true)")>]
    let mapBounded (p5: P5) (value: float) (start1: float) (stop1: float) (start2: float) (stop2: float) : float =
        jsNative

    [<Emit("$0.norm($1, $2, $3)")>]
    let norm (p5: P5) (value: float) (start: float) (stop: float) : float = jsNative

    type P5Vector =
        [<ImportDefault("p5")>]
        [<Emit("new $0.Vector($1, $2, $3)")>]
        static member create(?x: float, ?y: float, ?z: float) : P5Vector = jsNative

        [<ImportDefault("p5")>]
        [<Emit("$0.Vector.fromAngle($1)")>]
        static member fromAngle(angle: float) : P5Vector = jsNative

        [<ImportDefault("p5")>]
        [<Emit("$0.Vector.fromAngle($1, $2)")>]
        static member fromAngleAndLength (angle: float) (length: float) : P5Vector = jsNative

        [<ImportDefault("p5")>]
        [<Emit("$0.Vector.fromAngle($1, $2)")>]
        static member fromAngles (theta: float) (phi: float) : P5Vector = jsNative

        [<ImportDefault("p5")>]
        [<Emit("$0.Vector.fromAngles($1, $2, $3)")>]
        static member fromAnglesAndLength (theta: float) (phi: float) (length: float) : P5Vector = jsNative

        [<ImportDefault("p5")>]
        [<Emit("$0.Vector.random2D()")>]
        static member random2D() : P5Vector = jsNative

        [<ImportDefault("p5")>]
        [<Emit("$0.Vector.random3D()")>]
        static member random3D() : P5Vector = jsNative

        member self.x
            with get (): float = emitJsExpr (self) "$0.x"
            and set (x: float) = emitJsExpr (self, x) "$0.x = $1"

        member self.y
            with get (): float = emitJsExpr (self) "$0.y"
            and set (y: float) = emitJsExpr (self, y) "$0.y = $1"

        member self.z
            with get (): float = emitJsExpr (self) "$0.z"
            and set (z: float) = emitJsExpr (self, z) "$0.z = $1"

        [<Emit("$0.set($1, $2, $3)")>]
        member _.set(?x: float, ?y: float, ?z: float) : Unit = jsNative

        [<Emit("$0.set($1)")>]
        member private _.setFromValues_(values: ResizeArray<float>) : Unit = jsNative

        member self.setFromValues(values: float array) : Unit =
            values |> ResizeArray |> self.setFromValues_

        [<Emit("$0.set($1)")>]
        member _.setFromVector(v: P5Vector) : Unit = jsNative

        [<Emit("$0.toString()")>]
        member _.toString() : string = jsNative

        [<Emit("$0.add($1, $2)")>]
        member _.addXY (x: float) (y: float) : Unit = jsNative

        [<Emit("$0.mag()")>]
        member _.mag() : float = jsNative

        [<ImportDefault("p5")>]
        [<Emit("$0.Vector.mag($1)")>]
        static member mag(v: P5Vector) : float = jsNative

        [<Emit("$0.magSq()")>]
        member _.magSq() : float = jsNative

        [<ImportDefault("p5")>]
        [<Emit("$0.Vector.magSq($1)")>]
        static member magSq(v: P5Vector) : float = jsNative

        [<Emit("$0.copy()")>]
        member _.copy() : P5Vector = jsNative

        [<ImportDefault("p5")>]
        [<Emit("$0.Vector.copy($1)")>]
        static member copy(v: P5Vector) : P5Vector = jsNative

        [<Emit("$0.add($1, $2, $3)")>]
        member _.add(x: float, ?y: float, ?z: float) : Unit = jsNative

        [<Emit("$0.add($1)")>]
        member private _.addValues_(values: ResizeArray<float>) : Unit = jsNative

        member self.addValues(values: float array) : Unit =
            values |> ResizeArray |> self.addValues_

        [<Emit("$0.add($1)")>]
        member _.addVector(v: P5Vector) : Unit = jsNative

        [<ImportDefault("p5")>]
        [<Emit("$0.Vector.add($1, $2)")>]
        static member add(v1: P5Vector, v2: P5Vector) : P5Vector = jsNative

        [<ImportDefault("p5")>]
        [<Emit("$0.Vector.add($1, $2, $3)")>]
        static member addTo(v1: P5Vector, v2: P5Vector, target: P5Vector) : Unit = jsNative

        [<Emit("$0.sub($1, $2, $3)")>]
        member _.sub(x: float, ?y: float, ?z: float) : Unit = jsNative

        [<Emit("$0.sub($1)")>]
        member private _.subValues_(values: ResizeArray<float>) : Unit = jsNative

        member self.subValues(values: float array) : Unit =
            values |> ResizeArray |> self.subValues_

        [<Emit("$0.sub($1)")>]
        member _.subVector(v: P5Vector) : Unit = jsNative

        [<ImportDefault("p5")>]
        [<Emit("$0.Vector.sub($1, $2)")>]
        static member sub(v1: P5Vector, v2: P5Vector) : P5Vector = jsNative

        [<ImportDefault("p5")>]
        [<Emit("$0.Vector.sub($1, $2, $3)")>]
        static member subTo(v1: P5Vector, v2: P5Vector, target: P5Vector) : Unit = jsNative

        [<Emit("$0.mult($1)")>]
        member _.multScalar(n: float) : Unit = jsNative

        [<Emit("$0.mult($1, $2, $3)")>]
        member _.mult(x: float, y: float, ?z: float) : Unit = jsNative

        [<Emit("$0.mult($1)")>]
        member private _.multValues_(values: ResizeArray<float>) : Unit = jsNative

        member self.multValues(values: float array) : Unit =
            values |> ResizeArray |> self.multValues_

        [<Emit("$0.mult($1)")>]
        member _.multVector(v: P5Vector) : Unit = jsNative

        [<ImportDefault("p5")>]
        [<Emit("$0.Vector.mult($1, $2)")>]
        static member mult(v1: P5Vector, v2: P5Vector) : P5Vector = jsNative

        [<ImportDefault("p5")>]
        [<Emit("$0.Vector.mult($1, $2, $3)")>]
        static member multTo(v1: P5Vector, v2: P5Vector, target: P5Vector) : Unit = jsNative

        [<ImportDefault("p5")>]
        [<Emit("$0.Vector.mult($1, $2)")>]
        static member multScalar(v1: P5Vector, n: float) : P5Vector = jsNative

        [<ImportDefault("p5")>]
        [<Emit("$0.Vector.mult($1, $2, $3)")>]
        static member multScalarTo(v1: P5Vector, n: float, target: P5Vector) : Unit = jsNative

        [<ImportDefault("p5")>]
        [<Emit("$0.Vector.mult($1, $2)")>]
        static member private multValues_(v1: P5Vector, values: ResizeArray<float>) : P5Vector = jsNative

        [<ImportDefault("p5")>]
        [<Emit("$0.Vector.mult($1, $2)")>]
        static member multValues(v1: P5Vector, values: float array) : P5Vector =
            P5Vector.multValues_ (v1, ResizeArray values)

        [<ImportDefault("p5")>]
        [<Emit("$0.Vector.mult($1, $2, $3)")>]
        static member multValuesTo(v1: P5Vector, values: float array, target: P5Vector) : Unit =
            target.setFromVector (P5Vector.multValues (v1, values))

        [<Emit("$0.div($1)")>]
        member _.divScalar(n: float) : Unit = jsNative

        [<Emit("$0.div($1, $2, $3)")>]
        member _.div(x: float, y: float, ?z: float) : Unit = jsNative

        [<Emit("$0.div($1)")>]
        member private _.divValues_(values: ResizeArray<float>) : Unit = jsNative

        member self.divValues(values: float array) : Unit =
            values |> ResizeArray |> self.divValues_

        [<Emit("$0.div($1)")>]
        member _.divVector(v: P5Vector) : Unit = jsNative

        [<ImportDefault("p5")>]
        [<Emit("$0.Vector.div($1, $2)")>]
        static member div(v1: P5Vector, v2: P5Vector) : P5Vector = jsNative

        [<ImportDefault("p5")>]
        [<Emit("$0.Vector.div($1, $2, $3)")>]
        static member divTo(v1: P5Vector, v2: P5Vector, target: P5Vector) : Unit = jsNative

        [<ImportDefault("p5")>]
        [<Emit("$0.Vector.div($1, $2)")>]
        static member divScalar(v1: P5Vector, n: float) : P5Vector = jsNative

        [<ImportDefault("p5")>]
        [<Emit("$0.Vector.div($1, $2, $3)")>]
        static member divScalarTo(v1: P5Vector, n: float, target: P5Vector) : Unit = jsNative

        [<ImportDefault("p5")>]
        [<Emit("$0.Vector.div($1, $2)")>]
        static member private divValues_(v1: P5Vector, values: ResizeArray<float>) : P5Vector = jsNative

        [<ImportDefault("p5")>]
        [<Emit("$0.Vector.div($1, $2)")>]
        static member divValues(v1: P5Vector, values: float array) : P5Vector =
            P5Vector.divValues_ (v1, ResizeArray values)

        [<ImportDefault("p5")>]
        [<Emit("$0.Vector.div($1, $2, $3)")>]
        static member divValuesTo(v1: P5Vector, values: float array, target: P5Vector) : Unit =
            target.setFromVector (P5Vector.divValues (v1, values))

        [<Emit("$0.rem($1, $2, $3)")>]
        member _.rem(x: float, y: float, z: float) : Unit = jsNative

        [<Emit("$0.rem($1)")>]
        member private _.remFromValues_(values: ResizeArray<float>) : Unit = jsNative

        member self.remFromValues(values: float array) : Unit =
            values |> ResizeArray |> self.remFromValues_

        [<Emit("$0.rem($1)")>]
        member _.remFromVector(v: P5Vector) : Unit = jsNative

        [<ImportDefault("p5")>]
        [<Emit("$0.Vector.rem($1, $2)")>]
        static member rem(v1: P5Vector, v2: P5Vector) : P5Vector = jsNative

        [<Emit("$0.dot($1, $2, $3)")>]
        member _.dot(x: float, ?y: float, ?z: float) : float = jsNative

        [<ImportDefault("p5")>]
        [<Emit("$0.Vector.dot($1, $2)")>]
        static member dot(v1: P5Vector, v2: P5Vector) : float = jsNative

        [<Emit("$0.dot($1)")>]
        member _.dotVector(v: P5Vector) : float = jsNative

        [<Emit("$0.cross($1)")>]
        member _.cross(v: P5Vector) : P5Vector = jsNative

        [<ImportDefault("p5")>]
        [<Emit("$0.Vector.cross($1, $2)")>]
        static member cross(v1: P5Vector, v2: P5Vector) : P5Vector = jsNative

        [<Emit("$0.dist($1)")>]
        member _.dist(v: P5Vector) : float = jsNative

        [<ImportDefault("p5")>]
        [<Emit("$0.Vector.dist($1, $2)")>]
        static member dist(v1: P5Vector, v2: P5Vector) : float = jsNative

        [<Emit("$0.normalize()")>]
        member _.normalize() : Unit = jsNative

        [<ImportDefault("p5")>]
        [<Emit("$0.Vector.normalize($1)")>]
        static member normalize(v: P5Vector) : P5Vector = jsNative

        [<ImportDefault("p5")>]
        [<Emit("$0.Vector.normalize($1, $2)")>]
        static member normalizeTo(v: P5Vector, target: P5Vector) : P5Vector = jsNative

        [<Emit("$0.limit($1)")>]
        member _.limit(max: float) : Unit = jsNative

        [<ImportDefault("p5")>]
        [<Emit("$0.Vector.limit($1, $2)")>]
        static member limit(v: P5Vector, max: float) : P5Vector = jsNative

        [<ImportDefault("p5")>]
        [<Emit("$0.Vector.limit($1, $2, $3)")>]
        static member limitTo(v: P5Vector, max: float, target: P5Vector) : P5Vector = jsNative

        [<Emit("$0.setMag($1)")>]
        member _.setMag(len: float) : Unit = jsNative

        [<ImportDefault("p5")>]
        [<Emit("$0.Vector.setMag($1, $2)")>]
        static member setMag(v: P5Vector, len: float) : P5Vector = jsNative

        [<ImportDefault("p5")>]
        [<Emit("$0.Vector.setMag($1, $2, $3)")>]
        static member setMagTo(v: P5Vector, len: float, target: P5Vector) : Unit = jsNative

        [<Emit("$0.heading()")>]
        member _.heading() : float = jsNative

        [<ImportDefault("p5")>]
        [<Emit("$0.Vector.heading($1)")>]
        static member heading(v: P5Vector) : float = jsNative

        [<Emit("$0.setHeading($1)")>]
        member _.setHeading(angle: float) : Unit = jsNative

        [<Emit("$0.rotate($1)")>]
        member _.rotate(angle: float) : Unit = jsNative

        [<ImportDefault("p5")>]
        [<Emit("$0.Vector.rotate($1, $2)")>]
        static member rotate(v: P5Vector, angle: float) : P5Vector = jsNative

        [<ImportDefault("p5")>]
        [<Emit("$0.Vector.rotate($1, $2)")>]
        static member rotateTo(v: P5Vector, angle: float, target: P5Vector) : Unit = jsNative

        [<Emit("$0.angleBetween($1)")>]
        member _.angleBetween(v: P5Vector) : float = jsNative

        [<ImportDefault("p5")>]
        [<Emit("$0.Vector.angleBetween($1, $2)")>]
        static member angleBetween(v1: P5Vector, v2: P5Vector) : Unit = jsNative

        [<Emit("$0.lerp($1, $2, $3, $4)")>]
        member _.lerp(x: float, y: float, z: float, amount: float) : Unit = jsNative

        [<Emit("$0.lerp($1, $2, $3, $4)")>]
        member _.lerpVector(v: P5Vector, amount: float) : Unit = jsNative

        [<ImportDefault("p5")>]
        [<Emit("$0.Vector.lerp($1, $2, $3)")>]
        static member lerp(v1: P5Vector, v2: P5Vector, amount: float) : P5Vector = jsNative

        [<ImportDefault("p5")>]
        [<Emit("$0.Vector.lerp($1, $2, $3, $4)")>]
        static member lerpTo(v1: P5Vector, v2: P5Vector, amount: float, target: P5Vector) : Unit = jsNative

        [<Emit("$0.reflect($1)")>]
        member _.reflect(surfaceNormal: P5Vector) : Unit = jsNative

        [<ImportDefault("p5")>]
        [<Emit("$0.Vector.reflect($1, $2)")>]
        static member reflect(incidentVector: P5Vector, surfaceNormal: P5Vector) : P5Vector = jsNative

        [<ImportDefault("p5")>]
        [<Emit("$0.Vector.reflect($1, $2, $3)")>]
        static member reflectTo(incidentVector: P5Vector, surfaceNormal: P5Vector, target: P5Vector) : Unit = jsNative

        [<Emit("$0.array()")>]
        member _.array() : float array = jsNative

        [<ImportDefault("p5")>]
        [<Emit("$0.Vector.array($1)")>]
        static member array(v: P5Vector) : float array = jsNative

        [<Emit("$0.equals($1, $2, $3)")>]
        member _.equals(?x: float, ?y: float, ?z: float) : bool = jsNative

        [<Emit("$0.equals($1)")>]
        member _.equalsVector(v: P5Vector) : bool = jsNative

        [<Emit("$0.equals($1)")>]
        member private _.equalsValues_(values: ResizeArray<float>) : bool = jsNative

        member self.equalsValues(values: float array) : bool =
            values |> ResizeArray |> self.equalsValues_

        [<ImportDefault("p5")>]
        [<Emit("$0.Vector.equals($1, $2)")>]
        static member equals(v1: P5Vector, v2: P5Vector) : bool = jsNative

        [<ImportDefault("p5")>]
        [<Emit("$0.equals($1, $2)")>]
        static member private equalsValues_(v1: ResizeArray<float>, v2: ResizeArray<float>) : bool = jsNative

        static member equalsValues(v1: ResizeArray<float>, v2: ResizeArray<float>) : bool =
            P5Vector.equalsValues_ (ResizeArray v1, ResizeArray v2)

    let createVector: P5Vector = P5Vector.create ()

    let createVectorX (x: float) : P5Vector = P5Vector.create (x)

    let createVectorXY (x: float) (y: float) : P5Vector = P5Vector.create (x, y)

    let createVectorXYZ (x: float) (y: float) (z: float) : P5Vector = P5Vector.create (x, y, z)

    let createVector1D = createVectorX

    let createVector2D = createVectorXY

    let createVector3D = createVectorXYZ

    [<Emit("$0.constrain($1, $2, $3)")>]
    let constrain (p5: P5) (n: float) (min: float) (max: float) : float = jsNative

    [<Emit("$0.dist($1, $2, $3, $4)")>]
    let dist (p5: P5) (x1: float) (y1: float) (x2: float) (y2: float) : float = jsNative

    [<Emit("$0.dist($1, $2, $3, $4, $5, $6)")>]
    let dist3D (p5: P5) (x1: float) (y1: float) (z1: float) (x2: float) (y2: float) (z2: float) : float = jsNative

    [<Emit("$0.lerp($1, $2, $3)")>]
    let lerp (p5: P5) (start: float) (stop: float) (amt: float) : float = jsNative

    [<Emit("$0.mag($1, $2)")>]
    let mag (p5: P5) (a: float) (b: float) : float = jsNative

    [<Emit("$0.fract($1)")>]
    let fract (p5: P5) (x: float) : float = jsNative

    [<Emit("$0.randomSeed($1)")>]
    let randomSeed (p5: P5) (seed: float) : Unit = jsNative

    [<Emit("$0.random($1, $2)")>]
    let randomBetween (p5: P5) (min: float) (max: float) : float = jsNative

    [<Emit("$0.random($1)")>]
    let randomMax (p5: P5) (max: float) : float = jsNative

    let randomChoice<'T> (p5: P5) (choices: 'T seq) : 'T =
        emitJsExpr (p5, ResizeArray choices) "$0.random($1)"

    [<Emit("$0.randomGaussian()")>]
    let randomGaussian (p5: P5) = jsNative

    [<Emit("$0.randomGaussian($1)")>]
    let randomGaussianFromMean (p5: P5) (mean: float) = jsNative

    [<Emit("$0.randomGaussian($1, $2)")>]
    let randomGaussianFromMeanAndSd (p5: P5) (mean: float) (sd: float) = jsNative

    [<Emit("$0.noise($1)")>]
    let noise1D (p5: P5) (x: float) : float = jsNative

    [<Emit("$0.noise($1, $2, $3)")>]
    let noise2D (p5: P5) (x: float) (y: float) : float = jsNative

    [<Emit("$0.noise($1, $2, $3)")>]
    let noise3D (p5: P5) (x: float) (y: float) (z: float) : float = jsNative

    let noise = noise1D

    [<Emit("$0.noiseDetail($1, $2)")>]
    let noiseDetail (p5: P5) (lod: float) (falloff: float) : Unit = jsNative

    [<Emit("$0.noiseSeed($1)")>]
    let noiseSeed (p5: P5) (seed: float) : Unit = jsNative

    /// All trig functions exist in standard F# as well. We don't want to cause
    /// a name conflict, so we add them as static members to namespace them.
    /// The reason to keep both is because the p5 versions behave differently
    /// based on the current angle mode.
    type Trig =
        [<Emit("$0.acos($1)")>]
        static member acos (p5: P5) (x: float) : float = jsNative

        [<Emit("$0.asin($1)")>]
        static member asin (p5: P5) (x: float) : float = jsNative

        [<Emit("$0.atan($1)")>]
        static member atan (p5: P5) (x: float) : float = jsNative

        [<Emit("$0.atan2($1, $2)")>]
        static member atan2 (p5: P5) (y: float) (x: float) : float = jsNative

        [<Emit("$0.cos($1)")>]
        static member cos (p5: P5) (x: float) : float = jsNative

        [<Emit("$0.sin($1)")>]
        static member sin (p5: P5) (x: float) : float = jsNative

        [<Emit("$0.tan($1)")>]
        static member tan (p5: P5) (x: float) : float = jsNative

    [<Emit("$0.degrees($1)")>]
    let degrees (p5: P5) (radians: float) : float = jsNative

    [<Emit("$0.radians($1)")>]
    let radians (p5: P5) (degrees: float) : float = jsNative

    type AngleMode =
        | Degrees
        | Radians

    let getAngleMode (p5: P5) : AngleMode =
        let angleMode = emitJsExpr (p5) "$0.angleMode()"
        let p5' = unbox<obj> p5

        if p5'?("DEGREES") = angleMode then Degrees else Radians

    let angleMode = getAngleMode

    let setAngleMode (p5: P5) (angleMode: AngleMode) : Unit =
        let p5' = unbox<obj> p5

        let rawAngleMode =
            match angleMode with
            | Degrees -> p5'?("DEGREES")
            | Radians -> p5'?("RADIANS")

        emitJsExpr (p5, rawAngleMode) "$0.angleMode($1)"
