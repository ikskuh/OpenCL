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
 * Checks if a ray intersects with a box.
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
		intersection->normal = (float3)(0.0f, 0.0f, 0.0f);
		intersection->distance = dist;
	}
	return true;
}

/**
 * Checks if a ray intersects with a cuboid.
 * \return true if the ray hits the cuboid.
 */
bool intersect_cuboid(Ray *ray, Cuboid *cuboid, Intersection *intersection)
{
	Box box;
	box.minimum = cuboid->origin - 0.5f * cuboid->extends;
	box.maximum = cuboid->origin + 0.5f * cuboid->extends;
	return intersect_box(ray, &box, intersection);
}

#endif // _INTERSECT_H_