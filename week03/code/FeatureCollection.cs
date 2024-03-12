public class FeatureCollection {
    // Todo Earthquake Problem - ADD YOUR CODE HERE
    // Create additional classes as necessary
    public Feature[] features { get; set; }

    public void printFeatures() {
        foreach (Feature f in features)
        {
            string p = f.properties.place;
            double m = f.properties.mag;
            Console.WriteLine($"{p} - {String.Format("{0:0.##}", m)}");
        }
    }
}

public class Feature {
    public ActualFeature properties { get; set; }
}

public class ActualFeature {
    public double mag { get; set; }
    public string place { get; set; }
}

