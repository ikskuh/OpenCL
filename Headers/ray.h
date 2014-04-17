#ifndef _RAY_H_
#define _RAY_H_

/**
 * Defines a ray.
 */
typedef struct 
{
	/**
	 * Origin of the ray.
	 */
	float3 origin;
	/**
	 * Direction of the ray.
	 * \remarks Should be normalized.
	 */
	float3 direction;
} Ray;

#endif // #ifndef _RAY_H_