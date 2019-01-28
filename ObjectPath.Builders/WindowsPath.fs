namespace ObjectPath.Builders

module WindowsPathBuilder =
    type public PathSegment =
        | DriveLetter of DriveLetter : char
        | RelativeRootPathSegment of Segment : string
        | PathSegment of PathSegment * Segment : string
        with
            member public this.Append newSegment = PathSegment(this, newSegment)
        end

    let public (/) (beforeSegment : PathSegment) newSegment = beforeSegment.Append newSegment
    let public (./) driveLetter newSegment = (DriveLetter driveLetter)/newSegment
