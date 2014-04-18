#ifndef _GRAPHICS_H_
#define _GRAPHICS_H_

__constant float4 COLOR_RED = (float4)(1.0f, 0.0f, 0.0f, 1.0f);
__constant float4 COLOR_BLUE = (float4)(0.0f, 0.0f, 1.0f, 1.0f);

/**
 * Converts a color to 
 */
uchar4 color_to_bits(float4 color)
{
	return (uchar4)(
		(uchar)clamp(255.0f * color.z, 0.0f, 255.0f),
		(uchar)clamp(255.0f * color.y, 0.0f, 255.0f),
		(uchar)clamp(255.0f * color.x, 0.0f, 255.0f),
		(uchar)clamp(255.0f * color.w, 0.0f, 255.0f));
}

float4 bits_to_color(uchar4 color)
{
	float4 c;
	c.x = color.z / 255.0f;
	c.y = color.y / 255.0f;
	c.z = color.x / 255.0f;
	c.w = color.w / 255.0f;
	return c;
} 

#endif // #ifndef _GRAPHICS_H_