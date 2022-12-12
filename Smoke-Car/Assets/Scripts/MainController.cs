using UnityEngine;

namespace Smoke
{
    public class MainController : MonoBehaviour
    {
        private GameObject car;

        private void Awake()
        {
            // 装载资源。
            LoadResources();
        }

        // 装载地图资源。
        private void LoadResources()
        {
            // 加载地图平面。
            var plane = Instantiate(Resources.Load<GameObject>("Prefabs/Plane"));
            plane.name = "Plane";

            // 加载车辆资源。
            car = Instantiate(Resources.Load<GameObject>("Prefabs/Car"));
            car.name = "Car";

            // 加载边界预制。
            var wallPrefab = Resources.Load<GameObject>("Prefabs/Wall");
            // 绘制地图边界。
            {
                GameObject wall = Instantiate(wallPrefab);
                wall.transform.position = new Vector3(-25, 2, 0);
                wall.transform.localScale = new Vector3(1, 4, 100);
            }
            {
                GameObject wall = Instantiate(wallPrefab);
                wall.transform.position = new Vector3(25, 2, 0);
                wall.transform.localScale = new Vector3(1, 4, 100);
            }
            {
                GameObject wall = Instantiate(wallPrefab);
                wall.transform.position = new Vector3(0, 2, 50);
                wall.transform.localScale = new Vector3(50, 4, 1);
            }
            {
                GameObject wall = Instantiate(wallPrefab);
                wall.transform.position = new Vector3(0, 2, -50);
                wall.transform.localScale = new Vector3(50, 4, 1);
            }
        }
    }
}