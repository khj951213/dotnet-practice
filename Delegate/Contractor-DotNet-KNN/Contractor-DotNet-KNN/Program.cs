
using JuneDev_ML_KNN;

var contractors = new string[] { "Contractor 1", "Contractor 2", "Contractor 3", "Contractor 4", "Contractor 5" };

var points = new double[100][]
{
    new double[2] { 37.7749, -122.4194 }, // c1
    new double[2] { 34.0522, -118.2437 }, // c2 
    new double[2] { 40.7128, -74.0060 }, // c3
    new double[2] { 51.5074, -0.1278 },  // c4
    new double[2] { 41.8781, -87.6298 }, // c5,
    new double[2] { 37.7749, -122.4194 }, // c1
    new double[2] { 34.0522, -118.2437 }, // c2 
    new double[2] { 40.7128, -74.0060 }, // c3
    new double[2] { 51.5074, -0.1278 },  // c4
    new double[2] { 41.8781, -87.6298 }, // c5,
    new double[2] { 37.7749, -122.4194 }, // c1
    new double[2] { 34.0522, -118.2437 }, // c2 
    new double[2] { 40.7128, -74.0060 }, // c3
    new double[2] { 51.5074, -0.1278 },  // c4
    new double[2] { 41.8781, -87.6298 }, // c5,
    new double[2] { 37.7749, -122.4194 }, // c1
    new double[2] { 34.0522, -118.2437 }, // c2 
    new double[2] { 40.7128, -74.0060 }, // c3
    new double[2] { 51.5074, -0.1278 },  // c4
    new double[2] { 41.8781, -87.6298 }, // c5,
    new double[2] { 37.7749, -122.4194 }, // c1
    new double[2] { 34.0522, -118.2437 }, // c2 
    new double[2] { 40.7128, -74.0060 }, // c3
    new double[2] { 51.5074, -0.1278 },  // c4
    new double[2] { 41.8781, -87.6298 }, // c5,
    new double[2] { 37.7749, -122.4194 }, // c1
    new double[2] { 34.0522, -118.2437 }, // c2 
    new double[2] { 40.7128, -74.0060 }, // c3
    new double[2] { 51.5074, -0.1278 },  // c4
    new double[2] { 41.8781, -87.6298 }, // c5,
    new double[2] { 37.7749, -122.4194 }, // c1
    new double[2] { 34.0522, -118.2437 }, // c2 
    new double[2] { 40.7128, -74.0060 }, // c3
    new double[2] { 51.5074, -0.1278 },  // c4
    new double[2] { 41.8781, -87.6298 }, // c5,
    new double[2] { 37.7749, -122.4194 }, // c1
    new double[2] { 34.0522, -118.2437 }, // c2 
    new double[2] { 40.7128, -74.0060 }, // c3
    new double[2] { 51.5074, -0.1278 },  // c4
    new double[2] { 41.8781, -87.6298 }, // c5,
    new double[2] { 37.7749, -122.4194 }, // c1
    new double[2] { 34.0522, -118.2437 }, // c2 
    new double[2] { 40.7128, -74.0060 }, // c3
    new double[2] { 51.5074, -0.1278 },  // c4
    new double[2] { 41.8781, -87.6298 }, // c5,
    new double[2] { 37.7749, -122.4194 }, // c1
    new double[2] { 34.0522, -118.2437 }, // c2 
    new double[2] { 40.7128, -74.0060 }, // c3
    new double[2] { 51.5074, -0.1278 },  // c4
    new double[2] { 41.8781, -87.6298 }, // c5
    new double[2] { 37.7749, -122.4194 }, // c1
    new double[2] { 34.0522, -118.2437 }, // c2 
    new double[2] { 40.7128, -74.0060 }, // c3
    new double[2] { 51.5074, -0.1278 },  // c4
    new double[2] { 41.8781, -87.6298 }, // c5,
    new double[2] { 37.7749, -122.4194 }, // c1
    new double[2] { 34.0522, -118.2437 }, // c2 
    new double[2] { 40.7128, -74.0060 }, // c3
    new double[2] { 51.5074, -0.1278 },  // c4
    new double[2] { 41.8781, -87.6298 }, // c5,
    new double[2] { 37.7749, -122.4194 }, // c1
    new double[2] { 34.0522, -118.2437 }, // c2 
    new double[2] { 40.7128, -74.0060 }, // c3
    new double[2] { 51.5074, -0.1278 },  // c4
    new double[2] { 41.8781, -87.6298 }, // c5,
    new double[2] { 37.7749, -122.4194 }, // c1
    new double[2] { 34.0522, -118.2437 }, // c2 
    new double[2] { 40.7128, -74.0060 }, // c3
    new double[2] { 51.5074, -0.1278 },  // c4
    new double[2] { 41.8781, -87.6298 }, // c5,
    new double[2] { 37.7749, -122.4194 }, // c1
    new double[2] { 34.0522, -118.2437 }, // c2 
    new double[2] { 40.7128, -74.0060 }, // c3
    new double[2] { 51.5074, -0.1278 },  // c4
    new double[2] { 41.8781, -87.6298 }, // c5,
    new double[2] { 37.7749, -122.4194 }, // c1
    new double[2] { 34.0522, -118.2437 }, // c2 
    new double[2] { 40.7128, -74.0060 }, // c3
    new double[2] { 51.5074, -0.1278 },  // c4
    new double[2] { 41.8781, -87.6298 }, // c5,
    new double[2] { 37.7749, -122.4194 }, // c1
    new double[2] { 34.0522, -118.2437 }, // c2 
    new double[2] { 40.7128, -74.0060 }, // c3
    new double[2] { 51.5074, -0.1278 },  // c4
    new double[2] { 41.8781, -87.6298 }, // c5,
    new double[2] { 37.7749, -122.4194 }, // c1
    new double[2] { 34.0522, -118.2437 }, // c2 
    new double[2] { 40.7128, -74.0060 }, // c3
    new double[2] { 51.5074, -0.1278 },  // c4
    new double[2] { 41.8781, -87.6298 }, // c5,
    new double[2] { 37.7749, -122.4194 }, // c1
    new double[2] { 34.0522, -118.2437 }, // c2 
    new double[2] { 40.7128, -74.0060 }, // c3
    new double[2] { 51.5074, -0.1278 },  // c4
    new double[2] { 41.8781, -87.6298 }, // c5,
    new double[2] { 37.7749, -122.4194 }, // c1
    new double[2] { 34.0522, -118.2437 }, // c2 
    new double[2] { 40.7128, -74.0060 }, // c3
    new double[2] { 51.5074, -0.1278 },  // c4
    new double[2] { 41.8781, -87.6298 } // c5
};

var knn = new KNN(5);
knn.Fit(points);
var res = knn.Predict(new double[2] { 51.5074, -0.1278 });

//foreach (var item in res)
//{
//    Console.WriteLine(item);
//}

points = new double[100][]
{
    new double[2] { 500, res[0] }, // c1
    new double[2] { 500, res[1] }, // c2
    new double[2] { 400, res[2] }, // c3
    new double[2] { 300, res[3] }, // c4
    new double[2] { 300, res[4] }, // c5
    new double[2] { 500, res[0] }, // c1
    new double[2] { 500, res[1] }, // c2
    new double[2] { 400, res[2] }, // c3
    new double[2] { 300, res[3] }, // c4
    new double[2] { 300, res[4] }, // c5
    new double[2] { 500, res[0] }, // c1
    new double[2] { 500, res[1] }, // c2
    new double[2] { 400, res[2] }, // c3
    new double[2] { 300, res[3] }, // c4
    new double[2] { 300, res[4] }, // c5
    new double[2] { 500, res[0] }, // c1
    new double[2] { 500, res[1] }, // c2
    new double[2] { 400, res[2] }, // c3
    new double[2] { 300, res[3] }, // c4
    new double[2] { 300, res[4] }, // c5
    new double[2] { 500, res[0] }, // c1
    new double[2] { 500, res[1] }, // c2
    new double[2] { 400, res[2] }, // c3
    new double[2] { 300, res[3] }, // c4
    new double[2] { 300, res[4] }, // c5
    new double[2] { 500, res[0] }, // c1
    new double[2] { 500, res[1] }, // c2
    new double[2] { 400, res[2] }, // c3
    new double[2] { 300, res[3] }, // c4
    new double[2] { 300, res[4] }, // c5
    new double[2] { 500, res[0] }, // c1
    new double[2] { 500, res[1] }, // c2
    new double[2] { 400, res[2] }, // c3
    new double[2] { 300, res[3] }, // c4
    new double[2] { 300, res[4] }, // c5
    new double[2] { 500, res[0] }, // c1
    new double[2] { 500, res[1] }, // c2
    new double[2] { 400, res[2] }, // c3
    new double[2] { 300, res[3] }, // c4
    new double[2] { 300, res[4] }, // c5
    new double[2] { 500, res[0] }, // c1
    new double[2] { 500, res[1] }, // c2
    new double[2] { 400, res[2] }, // c3
    new double[2] { 300, res[3] }, // c4
    new double[2] { 300, res[4] }, // c5
    new double[2] { 500, res[0] }, // c1
    new double[2] { 500, res[1] }, // c2
    new double[2] { 400, res[2] }, // c3
    new double[2] { 300, res[3] }, // c4
    new double[2] { 300, res[4] }, // c5
    new double[2] { 500, res[0] }, // c1
    new double[2] { 500, res[1] }, // c2
    new double[2] { 400, res[2] }, // c3
    new double[2] { 300, res[3] }, // c4
    new double[2] { 300, res[4] }, // c5
    new double[2] { 500, res[0] }, // c1
    new double[2] { 500, res[1] }, // c2
    new double[2] { 400, res[2] }, // c3
    new double[2] { 300, res[3] }, // c4
    new double[2] { 300, res[4] }, // c5
    new double[2] { 500, res[0] }, // c1
    new double[2] { 500, res[1] }, // c2
    new double[2] { 400, res[2] }, // c3
    new double[2] { 300, res[3] }, // c4
    new double[2] { 300, res[4] }, // c5
    new double[2] { 500, res[0] }, // c1
    new double[2] { 500, res[1] }, // c2
    new double[2] { 400, res[2] }, // c3
    new double[2] { 300, res[3] }, // c4
    new double[2] { 300, res[4] }, // c5
    new double[2] { 500, res[0] }, // c1
    new double[2] { 500, res[1] }, // c2
    new double[2] { 400, res[2] }, // c3
    new double[2] { 300, res[3] }, // c4
    new double[2] { 300, res[4] }, // c5
    new double[2] { 500, res[0] }, // c1
    new double[2] { 500, res[1] }, // c2
    new double[2] { 400, res[2] }, // c3
    new double[2] { 300, res[3] }, // c4
    new double[2] { 300, res[4] }, // c5
    new double[2] { 500, res[0] }, // c1
    new double[2] { 500, res[1] }, // c2
    new double[2] { 400, res[2] }, // c3
    new double[2] { 300, res[3] }, // c4
    new double[2] { 300, res[4] }, // c5
    new double[2] { 500, res[0] }, // c1
    new double[2] { 500, res[1] }, // c2
    new double[2] { 400, res[2] }, // c3
    new double[2] { 300, res[3] }, // c4
    new double[2] { 300, res[4] }, // c5
    new double[2] { 500, res[0] }, // c1
    new double[2] { 500, res[1] }, // c2
    new double[2] { 400, res[2] }, // c3
    new double[2] { 300, res[3] }, // c4
    new double[2] { 300, res[4] }, // c5
    new double[2] { 500, res[0] }, // c1
    new double[2] { 500, res[1] }, // c2
    new double[2] { 400, res[2] }, // c3
    new double[2] { 300, res[3] }, // c4
    new double[2] { 300, res[4] }, // c5
};

//for (int i = 0; i < res.Length; i++)
//{
//    var rate = 5;
//    points[i] = new double[2] { res[i], rate - i };
//}


knn = new KNN(5);
knn.Fit(points);
res = knn.Predict(new double[2] { 500, 0 });
var bestContractor = "";
var min = double.MaxValue;
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"{contractors[i]}: {res[i]}");
    if (min > res[i])
    {
        min = res[i];
        bestContractor = $"Best contactor: {contractors[i]}";
    }
}

Console.WriteLine(bestContractor);