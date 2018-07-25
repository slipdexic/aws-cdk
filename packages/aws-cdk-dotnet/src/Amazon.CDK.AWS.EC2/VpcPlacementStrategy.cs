using AWS.Jsii.Runtime.Deputy;

namespace Amazon.CDK.AWS.EC2
{
    /// <summary>
    /// Customize how instances are placed inside a VPC
    /// 
    /// Constructs that allow customization of VPC placement use parameters of this
    /// type to provide placement settings.
    /// </summary>
    public class VpcPlacementStrategy : DeputyBase, IVpcPlacementStrategy
    {
        /// <summary>
        /// Whether to use the VPC's public subnets to start instances
        /// 
        /// If false, the instances are started in the private subnets.
        /// </summary>
        /// <remarks>default: false</remarks>
        [JsiiProperty("usePublicSubnets", "{\"primitive\":\"boolean\",\"optional\":true}", true)]
        public bool? UsePublicSubnets
        {
            get;
            set;
        }
    }
}