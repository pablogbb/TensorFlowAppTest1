using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tensorflow;

namespace TensorFlowAppTest1
{
    public interface IExample
    {
        /// <summary>
        /// True to run example
        /// </summary>
        bool Enabled { get; set; }

        /// <summary>
        /// Set true to import the computation graph instead of building it.
        /// </summary>
        bool IsImportingGraph { get; set; }

        string Name { get; }

        bool Run();

        /// <summary>
        /// Build dataflow graph, train and predict
        /// </summary>
        /// <returns></returns>
        void Train(Session sess);
        void Test(Session sess);

        void Predict(Session sess);

        Graph ImportGraph();

        Graph BuildGraph();

        /// <summary>
        /// Prepare dataset
        /// </summary>
        void PrepareData();

    }
}
