#ifndef _INTERSECT_H_
#define _INTERSECT_H_

#include <common.h>
#include <ray.h>

/**
 * Defines a cuboid.
 */
typedef struct
{
	/**
	 * Origin of the cuboid.
	 */
	float3 origin;
	
	/**
	 * Extends of the cuboid.
	 */
	float3 extends;
} Cuboid;

/**
 * Defines a box.
 */
typedef struct
{
	/**
	 * Back right bottom corner.
	 */
	float3 minimum;
	/**
	 * Front left top corner.
	 */
	float3 maximum;
} Box;

/**
 * Defines a sphere.
 */
typedef struct
{
	/**
	 * Center of the sphere.
	 */
	float3 origin;
	/**
	 * Radius of the sphere.
	 */
	float radius;
} Sphere;

/**
 * Defines a intersection.
 */
typedef struct
{
	/**
	 * Position of the intersection.
	 */
	float3 position;
	
	/**
	 * Normal at the intersection.
	 */
	float3 normal;
	
	/**
	 * Distance to the intersection point.
	 */
	float distance;
} Intersection;

/**
 * Checks if a ray intersects a box.
 * \return true if the ray hits the box.
 */
bool intersect_box(Ray *ray, Box *box, Intersection *intersection)
{
	float dist = 0.0f;
	float maxValue = FLT_MAX;
	if (fabs(ray->direction.x) < 1E-06f)
	{
		if ((ray->origin.x < box->minimum.x) || (ray->origin.x > box->maximum.x))
		{
			return false;
		}
	}
	else
	{
		float num11 = 1.0f / ray->direction.x;
		float num8 = (box->minimum.x - ray->origin.x) * num11;
		float num7 = (box->maximum.x - ray->origin.x) * num11;
		if (num8 > num7)
		{
			float temp = num8;
			num8 = num7;
			num7 = temp;
		}
		dist = max(num8, dist);
		maxValue = min(num7, maxValue);
		if (dist > maxValue)
		{
			return false;
		}
	}
	if (fabs(ray->direction.y) < 1E-06f)
	{
		if ((ray->origin.y < box->minimum.y) || (ray->origin.y > box->maximum.y))
		{
			return false;
		}
	}
	else
	{
		float num10 = 1.0f / ray->direction.y;
		float num6 = (box->minimum.y - ray->origin.y) * num10;
		float num5 = (box->maximum.y - ray->origin.y) * num10;
		if (num6 > num5)
		{
			float temp = num6;
			num6 = num5;
			num5 = temp;
		}
		dist = max(num6, dist);
		maxValue = min(num5, maxValue);
		if (dist > maxValue)
		{
			return false;
		}
	}
	if (fabs(ray->direction.z) < 1E-06f)
	{
		if ((ray->origin.z < box->minimum.z) || (ray->origin.z > box->maximum.z))
		{
			return false;
		}
	}
	else
	{
		float num9 = 1.0f / ray->direction.z;
		float num4 = (box->minimum.z - ray->origin.z) * num9;
		float num3 = (box->maximum.z - ray->origin.z) * num9;
		if (num4 > num3)
		{
			float temp = num4;
			num4 = num3;
			num3 = temp;
		}
		dist = max(num4, dist);
		maxValue = min(num3, maxValue);
		if (dist > maxValue)
		{
			return false;
		}
	}
	if(intersection != nullptr)
	{
		intersection->position = ray->origin + dist * ray->direction;
		intersection->distance = dist;
		
		float3 offset = intersection->position - (0.5f * box->maximum + 0.5f * box->minimum);
		offset /= (box->maximum - box->minimum);
		
		if(fabs(offset.x) > fabs(offset.y) && fabs(offset.x) > fabs(offset.z))
		{
			intersection->normal = (float3)((float)sign(offset.x), 0.0f, 0.0f);
		}
		else if(fabs(offset.y) > fabs(offset.z))
		{
			intersection->normal = (float3)(0.0f, (float)sign(offset.y), 0.0f);
		}
		else
		{
			intersection->normal = (float3)(0.0f, 0.0f, (float)sign(offset.z));
		}
	}
	return true;
}

/**
 * Checks if a ray intersects a cuboid.
 * \return true if the ray hits the cuboid.
 */
bool intersect_cuboid(Ray *ray, Cuboid *cuboid, Intersection *intersection)
{
	Box box;
	box.minimum = cuboid->origin - 0.5f * cuboid->extends;
	box.maximum = cuboid->origin + 0.5f * cuboid->extends;
	return intersect_box(ray, &box, intersection);
}

/**
* Checks if a ray intersects a sphere.
* \return true if the ray hits the sphere.
*/
bool intersect_sphere(Ray *ray, Sphere *sphere, Intersection *intersection)
{
	float num = sphere->origin.x - ray->origin.x;
	float num2 = sphere->origin.y - ray->origin.y;
	float num3 = sphere->origin.z - ray->origin.z;
	float num4 = num * num + num2 * num2 + num3 * num3;
	float num5 = sphere->radius * sphere->radius;
	if (num4 <= num5)
	{
		if (intersection != nullptr)
		{
			intersection->distance = distance(sphere->origin, ray->origin);
			intersection->normal = normalize(ray->origin - sphere->origin);
			intersection->position = sphere->origin;
		}
		return true;
	}
	float num6 = num * ray->direction.x + num2 * ray->direction.y + num3 * ray->direction.z;
	if (num6 < 0.0f)
	{
		return false;
	}
	float num7 = num4 - num6 * num6;
	if (num7 > num5)
	{
		return false;
	}
	float num8 = sqrt(num5 - num7);

	if(intersection != nullptr)
	{
		intersection->distance = (num6 - num8);
		intersection->position = ray->origin + intersection->distance * ray->direction;
		intersection->normal = normalize(intersection->position - sphere->origin);
	}
	return true;
}

#endif // _INTERSECT_H_